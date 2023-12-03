using MoneyBank.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FerPROJ.Design.Forms.FrmManage;

namespace MoneyBank.Forms {
    public class FormLayer {

        public class ManageForm {
            public bool ManageUser(string id, FormMode formMode) {
                using (var frm = new ManageUser()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageLogin() {
                using (var frm = new ManageLogin()) {
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageBank(string id, FormMode formMode) {
                using (var frm = new ManageBank()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageBankInfo(string id, FormMode formMode) {
                using (var frm = new ManageUserBankInfo()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageUserBank(UserBankDTO myDTO, FormMode formMode) {
                using (var frm = new ManageUserBank()) {
                    frm.myDTO = myDTO;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageUserBankAccount(UserBankAccountDTO myDTO, List<UserBankDTO> BankList, FormMode formMode) {
                using (var frm = new ManageUserBankAccount()) {
                    frm.myDTO = myDTO;
                    frm.BankList = BankList;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageUserInfo(UserInformationDTO myDTO, FormMode formMode) {
                using (var frm = new ManageUserInfo()) {
                    frm.myDTO = myDTO;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageExpenseType(string id, FormMode formMode) {
                using (var frm = new ManageExpenseType()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageReceiveType(string id, FormMode formMode) {
                using (var frm = new ManageReceiveType()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageExpense(string id, FormMode formMode) {
                using (var frm = new ManageExpense()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();                   
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageExpenseDetails(ExpenseDetailDTO myDTO, FormMode formMode) {
                using (var frm = new ManageExpenseDetail()) {
                    frm.myDTO = myDTO;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    myDTO = frm.myDTO;
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageReceive(string id, FormMode formMode) {
                using (var frm = new ManageReceive()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();                    
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageReceiveDetails(ReceiveDetailDTO myDTO, FormMode formMode) {
                using (var frm = new ManageReceiveDetail()) {
                    frm.myDTO = myDTO;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    myDTO = frm.myDTO;
                    return frm.CurrentFormResult;
                }
            }
            public bool ManageBankTransfer() {
                using (var frm = new ManageBankTransfer()) {
                    frm.ShowDialog();
                    return frm.CurrentFormResult;
                }
            }
        }
        public class ListForm {
            public bool ListBanks() {
                using (var frm = new FrmBanks()) {
                    frm.ShowDialog();
                    return true;
                }
            }
            public bool ListUsers(out string sout) {
                using (var frm = new FrmUsers()) {
                    frm.ShowDialog();
                    sout = frm.Form_IdTrack;
                    return true;
                }
            }
            public bool ListExpenseType() {
                using (var frm = new FrmExpenseType()) {
                    frm.ShowDialog();
                    return true;
                }
            }
            public bool ListReceiveType() {
                using (var frm = new FrmReceiveTypes()) {
                    frm.ShowDialog();
                    return true;
                }
            }
            public bool ListExpense() {
                using (var frm = new FrmExpense()) {
                    frm.ShowDialog();
                    return true;
                }
            }
            public bool ListReceive() {
                using (var frm = new FrmReceive()) {
                    frm.ShowDialog();
                    return true;
                }
            }
        }

    }
}
