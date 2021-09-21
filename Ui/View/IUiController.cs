using System;
using System.Collections.Generic;

namespace tickethelper.Ui.View
{
    internal interface IUiController
    {
        string KeyWord { get; }
        bool CanForward { set; }
        bool CanBackward { set; }

        bool CanAccessGestaoTelecom { set; }
        bool DetailedViewDocked { get; }
        List<object> DetailedDataSource { get; set; }

        /*----------- User --------------*/
        string DisplayName { get; set; }
        string Title { set; }
        string Department { set; }
        string EmployeeId { set; }
        string GlobalId { set; }
        string Mail {set; }
        string HeiwayId { set; }
        string OpCo { set; }
        bool IsVip { set; }
        bool IsUserFound { set; }
        bool NamesMatch { get; set; }
        bool MailsMatch { get; set; }
        string TelephoneNumber { get; set; }
        string Mobile { get; set; }
        bool EmployeeIdMatch { get; set; }
        /*----------- Manager ------------*/
        string ManagerName { set; }
        string ManagerMail { set; }
        string ManagerId { set; }
        bool IsManagerFound { set; }

        /*----------- HeiwayAccount ------------*/
        bool IsHeiwayAccountDisabled { set; }
        bool IsHeiDm { set; }
        bool? IsHeiwayAutoUnlocked { set; }
        DateTime? HeiwayAccountExpireDate { set; }
        bool IsHeiwayAccountExpired { set; }
        DateTime? HeiwayPwdExpireDate { set; }
        bool IsHeiwayPwdExpired { set; }
        string HeiwayBadPwd { set; }
        bool IsHeiwayAccountFound { set; }

        /*----------- Schin ------------*/
        bool IsSchinAccountDisabled { set; }
        bool? IsSchinAutoUnlocked { set; }
        DateTime? SchinAccountExpireDate { set; }
        bool IsSchinAccountExpired { set; }
        DateTime? SchinPwdExpireDate { set; }
        bool IsSchinPwdExpired { set; }
        string SchinBadPwd { set; }
        bool IsSchinAccountFound { set; }
    }
}