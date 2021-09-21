using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using tickethelper.Model;
using tickethelper.Service;
using tickethelper.Service.ActiveDirectory;
using tickethelper.Ui;
using tickethelper.Ui.Core;
using tickethelper.Ui.View;

namespace tickethelper.Controller
{
    internal class MainUiController
    {
        private const string MoreThanAResultFoundWarning = @"Mais de um resultado encontrado, mostrar exibição detalhada?";
        private const string DivergenceWarning = @"Possíveis divergências, mostrar exibição detalhada?";
        private readonly Stack<string> _backwardKeywordStack = new Stack<string>();
        private readonly Stack<string> _forwardKeywordStack = new Stack<string>();
        private readonly IUiController _userView;
        public MainUiController(IUiController view) => _userView = view;

        private User _currentUser;
        public HashSet<FriendlyUserAccount> CurrentAccountSet => SearchEngine.CurrentAccountSet;
        public IEnumerable<User> CurrentMatches => SearchEngine.CurrentMatches;

        private string KeyWord
        {
            get
            {
                _backwardKeywordStack.Push(_userView.KeyWord);
                return _userView.KeyWord;
            }
        }

        public void Search()
        {
            _forwardKeywordStack.Clear();
            SearchEngine.Search(KeyWord);
            LoadAllData();
            ValidateSearchResults();
        }

        public void Refresh(bool userData = false)
        {
            SearchEngine.Search(_backwardKeywordStack.Peek());
           _currentUser = SearchEngine.CurrentUser;
            LoadHeiwayAccount();
            LoadSchincariolAccount();
            if (userData) LoadUserData();
        }

        public void Backward()
        {
            _forwardKeywordStack.Push(_backwardKeywordStack.Pop());
            SearchEngine.Search(_backwardKeywordStack.Peek());
            LoadAllData();
        }

        public void Forward()
        {
            _backwardKeywordStack.Push(_forwardKeywordStack.Peek());
            SearchEngine.Search(_forwardKeywordStack.Pop());
            LoadAllData();
        }

        private void LoadAllData()
        {
            _currentUser = SearchEngine.CurrentUser;
            SetVisibility();
            LoadUserData();
            LoadManagerData();
            LoadHeiwayAccount();
            LoadSchincariolAccount();
            OnboardingForm.ShowInOnboardingPanel(_currentUser);
        }

        private void SetVisibility()
        {
            _userView.CanBackward = _backwardKeywordStack.Count > 1;
            _userView.CanForward = _forwardKeywordStack.Count > 0;
            _userView.CanAccessGestaoTelecom = CanAccessGestaoTelecom();
            _userView.IsHeiwayAccountFound = !(_currentUser?.HeiwayAccount is null);
            _userView.IsSchinAccountFound = !(_currentUser?.SchincariolAccount is null);
            _userView.IsUserFound = !(_currentUser is null);
            _userView.IsManagerFound = !(_currentUser?.Manager is null);
        }
        public void LoadUserData()
        {
            if (_currentUser is null)
            {
                _userView.DetailedDataSource = null;
                return;
            }

            if (_userView.DetailedViewDocked) _userView.DetailedDataSource = null;

            _userView.NamesMatch = MoreThanAResultFound() || _currentUser.Validate.NamesMatch();
            _userView.MailsMatch = MoreThanAResultFound() || _currentUser.Validate.MailsMatch();
            _userView.EmployeeIdMatch = MoreThanAResultFound() || _currentUser.Validate.EmployeeIdMatch();
            _userView.DetailedDataSource = GetDetailedAttributeList();
            _userView.DisplayName = _currentUser.IsVip ? $"     {_currentUser.Name}" : _currentUser.Name;
            _userView.Title = _currentUser.Title;
            _userView.Department = _currentUser.Department;
            _userView.EmployeeId = _currentUser.EmployeeId;
            _userView.GlobalId = _currentUser.GlobalId;
            _userView.Mail = _currentUser.Mail;
            _userView.HeiwayId = _currentUser.HeiwayId;
            _userView.OpCo = _currentUser.OpCo;
            _userView.IsVip = _currentUser.IsVip;
            _userView.TelephoneNumber = _currentUser.TelephoneNumber;
            _userView.Mobile = _currentUser.Mobile;
            CopyUserData(true);
        }

        public void LoadManagerData()
        {
            if (_currentUser?.Manager is null) return;
            _userView.ManagerName = _currentUser?.Manager.Name;
            _userView.ManagerMail = _currentUser?.Manager.Mail;
            _userView.ManagerId = _currentUser?.Manager.HeiwayId;
        }

        private void LoadHeiwayAccount()
        {
            if (_currentUser?.HeiwayAccount is null) return;
            _userView.IsHeiDm = _currentUser.IsHeiDm;
            _userView.IsHeiwayAutoUnlocked = _currentUser.HeiwayAccount.AutoUnlocked;
            _userView.IsHeiwayAccountDisabled = _currentUser.HeiwayAccount.IsDisabled();
            _userView.IsHeiwayAccountExpired = _currentUser.HeiwayAccount.IsExpired();
            _userView.HeiwayAccountExpireDate = _currentUser.HeiwayAccount.AccountExpires;
            _userView.IsHeiwayPwdExpired = _currentUser.HeiwayAccount.IsPwdExpired();
            _userView.HeiwayPwdExpireDate = _currentUser.HeiwayAccount.PwdLastSet?.AddDays(90);
            _userView.HeiwayBadPwd = _currentUser.HeiwayAccount.BadPwdCount.ToString();
        }

        private void LoadSchincariolAccount()
        {
            if (_currentUser?.SchincariolAccount is null) return;
            _userView.IsSchinAutoUnlocked = _currentUser.SchincariolAccount.AutoUnlocked;
            _userView.IsSchinAccountDisabled = _currentUser.SchincariolAccount.IsDisabled();
            _userView.IsSchinAccountExpired = _currentUser.SchincariolAccount.IsExpired();
            _userView.SchinAccountExpireDate = _currentUser.SchincariolAccount.AccountExpires;
            _userView.IsSchinPwdExpired = _currentUser.SchincariolAccount.IsPwdExpired();
            _userView.SchinPwdExpireDate = _currentUser.SchincariolAccount.PwdLastSet?.AddDays(90);
            _userView.SchinBadPwd = _currentUser.SchincariolAccount.BadPwdCount.ToString();
        }

        public void CopyUserData(bool copyPhone = false)
        {
            if (_currentUser is null) return;
            Clipboard.SetText(_currentUser.ToString(copyPhone));
        }

        public void CopyEnglishUserData()
        {
            if (_currentUser is null) return;
            Clipboard.SetText(_currentUser.GetEnglishData());
        }

        public void CopyManagerData()
        {
            if (_currentUser?.Manager is null) return;
            Clipboard.SetText(_currentUser?.Manager.ToString());
        }

        public void ShowScriptsForUser()
        {
            new ScriptGenForm(_currentUser).Show();
        }

        public void ToggleHeiwayAccount()
        {
            _currentUser.HeiwayAccount.Manage.Toggle();
            Refresh();
        }

        public void ToggleSchinAccount()
        {
            _currentUser.SchincariolAccount.Manage.Toggle();
            Refresh();
        }

        public void ChangeHeiwayPassword()
        {
            _currentUser.HeiwayAccount.Manage.ResetPassword();
            Refresh();
        }

        public void ChangeSchinPassword()
        {
            _currentUser.SchincariolAccount.Manage.ResetPassword();
            Refresh();
        }

        public void ShowHeiwayDetails() => _currentUser.HeiwayAccount.ShowDetails();


        public void ShowSchinDetails() => _currentUser.SchincariolAccount.ShowDetails();

        public void ChangePhone()
        {
            if (_currentUser?.HeiwayAccount is null) return;
            _currentUser.HeiwayAccount.Manage.ChangePhone();
            Refresh(true);
        }

        private bool MoreThanAResultFound()
        {
            if (!(CurrentMatches is null))
                return CurrentMatches.Count() > 1;
            return CurrentAccountSet.Count > 1;
        }

        // Check if multiple accounts were found or there is a difference between them

        private DialogResult WarnMoreThanAResultFound()
        {
            return _userView.DetailedViewDocked ?
                MessageBox.Show("Mais de um resultado encontrado.",
                    @"Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                : MessageBox.Show(MoreThanAResultFoundWarning,
                @"Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }

        private DialogResult WarnDivergence()
        {
            return _userView.DetailedViewDocked ?
                MessageBox.Show("Possíveis divergências nos resultados.",
                    @"Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)

                : MessageBox.Show(DivergenceWarning,
                    @"Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
        }
        private void ValidateSearchResults()
        {
            if (_currentUser is null || _userView.DetailedViewDocked) return;
            var divergence = false;
            var dialogResult = DialogResult.No;
            if (MoreThanAResultFound())
                dialogResult = WarnMoreThanAResultFound();
            else if (_currentUser.Validate.HasDivergence())
            {
                dialogResult = WarnDivergence();
                divergence = true;
            }

            if (dialogResult == DialogResult.Yes) ShowDetailedView(divergence);
        }

        public void ShowDetailedView(bool divergence = false)
        {
            if (_currentUser is null) return;

            var detailedView = divergence
                ? new DetailedViewForm(
                        _currentUser.Validate.NamesMatch(),
                        _currentUser.Validate.MailsMatch(),
                        _currentUser.Validate.EmployeeIdMatch())

                { DataSource = GetDetailedAttributeList() }
                : new DetailedViewForm
                    { DataSource = GetDetailedAttributeList() };

            detailedView.Show();
        }

        private List<object> GetDetailedAttributeList()
        {
            var detailedViewList = from properties in CurrentAccountSet
                                   select (object)new
                                   {
                                       Conta = properties.SamAccountName,
                                       Nome = properties.DisplayName,
                                       Email = properties.Mail,
                                       extensionAttribute5 = properties.ExtensionAttribute5
                                   };
            return detailedViewList.ToList();
        }

        private bool CanAccessGestaoTelecom() 
        {
            var isHeineken = "EMP".Equals(_currentUser?.EmployeeType, StringComparison.OrdinalIgnoreCase);
            var hasEmployeeId = _currentUser?.EmployeeId != null;

            return isHeineken && hasEmployeeId;
        }

        public void ShowInGestaoTelecom()
        {
            new GestaoTelecomForm(_currentUser.EmployeeId.Any(char.IsLetter) 
                ? _currentUser.SchincariolAccount?.SamAccountName 
                : _currentUser.EmployeeId )
                .Show();
        }
    }
}