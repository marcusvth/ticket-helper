using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using tickethelper.Model;

namespace tickethelper.Service.ActiveDirectory
{
    internal static class SearchEngine
    {
        private const int QueryStartIndex = 30;
        private const int QueryMinLength = 32;
        private const int MaxResults = 20;
        private static readonly string[] CommonProperties = { "accountExpires", "badPwdCount", "department", "description", "displayName", "givenName", "memberOf", "lockoutTime", "mail", "mobile", "pwdLastSet", "sAMAccountName", "sn", "telephoneNumber", "title", "userAccountControl", "whenCreated" };
        private static readonly string[] HeiwayProperties = { "company", "employeeType", "employeeNumber", "extensionAttribute5", "extensionAttribute8", "extensionAttribute10", "extensionAttribute11", "info", "manager", "physicalDeliveryOfficeName" };

        private static readonly DirectoryEntry[] Entries = 
            {EntryManager.GetEntry(SchincariolDomain), EntryManager.GetEntry(HeiwayDomain)
    };

    public static HashSet<FriendlyUserAccount> CurrentAccountSet = new HashSet<FriendlyUserAccount>();
        public static IEnumerable<User> CurrentMatches = new List<User>();
        private static string HeiwayDomain => EntryManager.HeiwayDomain;
        private static string SchincariolDomain => EntryManager.SchincariolDomain;
        public static User CurrentUser =>
            CurrentMatches.OrderByDescending(user => user.GetScore())
                          .ThenByDescending(user => user.HeiwayAccount.WhenCreated)
                          .ThenByDescending(user => user.SchincariolAccount.WhenCreated).FirstOrDefault() ??
                            
            User.Create(CurrentAccountSet.FirstOrDefault());
        public static User Search(string keyWord)
        {
            CurrentAccountSet = FindAllAccounts(keyWord);
            CurrentMatches = GetUserMatches(CurrentAccountSet);
            return CurrentUser;
        }

        // Use this to get a user without affect the results
        public static User GetUser(string distinguishedName)
        {
            var accountSet = FindAllAccounts(distinguishedName);
            return GetUserMatches(accountSet).OrderByDescending(user => user.GetScore()).FirstOrDefault() ??
                   User.Create(accountSet.FirstOrDefault());
        }
        private static IEnumerable<User> GetUserMatches(HashSet<FriendlyUserAccount> accountSet)
        {
            return from heiwayAccount in accountSet.Where(account =>
                    account.Path.Contains(HeiwayDomain))
                from schincariolAccount in accountSet.Where(
                    account => account.Path.Contains(SchincariolDomain))
                select User.Create(heiwayAccount, schincariolAccount);
        }

        private static HashSet<FriendlyUserAccount> FindAllAccounts(string keyWord)
        {
            if (string.IsNullOrWhiteSpace(keyWord)) return new HashSet<FriendlyUserAccount>();
            var results = new HashSet<FriendlyUserAccount>();
            DirectoryEntry missingResultsEntry = null;
            foreach (var entry in Entries)
                using (var directorySearcher = new DirectorySearcher(entry, BuildQuery(keyWord)) {SizeLimit = MaxResults, Sort = new SortOption("whenCreated", SortDirection.Descending)})
                {
                    directorySearcher.PropertiesToLoad.AddRange(entry.Path == EntryManager.HeiwayDomain ? HeiwayProperties.Union(CommonProperties).ToArray() : CommonProperties);
                    var accounts = directorySearcher.FindAll();
                    if (accounts.Count is 0) missingResultsEntry = entry;
                    foreach (SearchResult account in accounts)
                        results.Add(FriendlyUserAccount.Create(account));
                }

            GetMissingResults(ref results, missingResultsEntry);
            return results;
        }

        private static void GetMissingResults(ref HashSet<FriendlyUserAccount> source, DirectoryEntry entry)
        {
            if (source.Count is 0 || entry is null) return;
            using (var directorySearcher = new DirectorySearcher(entry) {SizeLimit = MaxResults, Sort = new SortOption("whenCreated", SortDirection.Descending) })
            {
                directorySearcher.PropertiesToLoad.AddRange(entry.Path == EntryManager.HeiwayDomain ? HeiwayProperties.Union(CommonProperties).ToArray() : CommonProperties);
                foreach (var query in source.ToList().Select(BuildQuery).Where(query => query.Length > QueryMinLength))
                {
                    directorySearcher.Filter = query;
                    foreach (SearchResult account in directorySearcher.FindAll())
                        source.Add(FriendlyUserAccount.Create(account));
                }
            }
        }

        // Builds a query to search accounts in the other sever
        private static string BuildQuery(FriendlyUserAccount account)
        {
            var displayName = account.Path.Contains(SchincariolDomain)? account.DisplayName?.Split('-')[0].Trim() : account.DisplayName;

            Log.Add($"Iniciando construção de query baseada na conta {account.SamAccountName}", 1);

            var query = new StringBuilder("(&(sAMAccountType=805306368)(|))");

            if (account.Path.Contains(SchincariolDomain))
                query.Insert(QueryStartIndex, $"(extensionAttribute5={account.SamAccountName})"); // Just for Heiway server

            if (!(account.ExtensionAttribute5 is null))
                query.Insert(QueryStartIndex,
                    $"(sAMAccountName={account.ExtensionAttribute5})"); // Just for Schincariol server

            if (!(account.Mail is null))
                query.Insert(QueryStartIndex, $"(mail={account.Mail}*)");

            if (!(account.JoinedName is null) || !(displayName is null))
                query.Insert(QueryStartIndex, $"(displayName={displayName ?? account.JoinedName}*)");

            Log.Add("Query construída: " + query, 1);

            return query.ToString();
        }

        private static string BuildQuery(string input)
        {
            Log.Add($"Iniciando construção de query com o parâmetro '{input}'", 1);

            input = input.Trim();
            var builder = new StringBuilder("(&(sAMAccountType=805306368)(|")
                .Append("(extensionAttribute5={0}*)")
                //.Append("(employeeNumber={0})") // Enables GlobalID search
                .Append("(sAMAccountName={0}*)")
                .Append("(mail={0}*)")
                .Append("(displayName={0}*)")
                .Append("(givenName={0})")
                //.Append("(sn={0}*)") // Experimental
                .Append("(distinguishedName={0})")
                .Append("))");

            var baseQuery = input.Contains('*') ? builder.ToString().Replace("*", "") : builder.ToString();

            // Replaces "*" to an Empty String to use forced query with "firstWord * lastWord"

            var query = string.Format(baseQuery, input);

            Log.Add("Query construída: " + query, 1);
            return query;
        }
    }
}