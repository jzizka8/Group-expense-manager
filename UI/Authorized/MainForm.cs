using Microsoft.EntityFrameworkCore;
using Project.BusinessLayer;
using Project.BusinessLayer.DebtManaging;
using Project.Models;
using Project.UI.Authorized.ExpenseManaging;
using Project.UI.Authorized.GroupManaging;

namespace Project.UI.Authorized
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        private Group selectedGroup;
        public MainForm(User user)
        {
            InitializeComponent();

            
            User = user;
            LogedUserLbl.Text = User.Username;

            AddMemberBtn.Enabled = selectedGroup != null;
            _ = RefreshGroupListAsync();
        }

        private async Task RefreshGroupListAsync()
        {
            var groupManager = new GroupManager();
            List<Group> groups = await groupManager.GetGroupsAsync(User);

            GroupSelectComb.DataSource = groups.ToList();
        }

        private async Task LoadGroupAsync()
        {
            var groupManager = new GroupManager();
            selectedGroup = await groupManager.GetGroupEagerAsync((Group)(GroupSelectComb.SelectedValue));
        }

        private void AssignGroupControlsValues()
        {
            MembersListBox.DataSource = selectedGroup.Members.ToList();
            ExpensesListBox.DataSource = selectedGroup.Expenses.Reverse().ToList();

            AddMemberBtn.Enabled = selectedGroup.IsManagedBy(User);
        }

        private async Task LoadDebtsListAsync()
        {
            DebtCalculator debtCalculator = new();
            DebtsListBox.DataSource = await Task.Run(() => debtCalculator.CalculateDebts(selectedGroup.Expenses));
        }

        private async Task RefreshGroupAsync()
        {
            await LoadGroupAsync();
            AssignGroupControlsValues();
            await LoadDebtsListAsync();
        }
        

        #region Event Handlers
        private async void GroupSelectComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddExpenseBtn.Enabled = true;
            
            await RefreshGroupAsync();
        }
        private async void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            Form createGroup = new CreateGroupForm(User);
            createGroup.ShowDialogAlignedWith(this);
            await RefreshGroupListAsync();
        }
        private async void AddMemberBtn_Click(object sender, EventArgs e )
        {
            Form addMember = new AddGroupMemberForm(selectedGroup);
            addMember.ShowDialogAlignedWith(this);

            await LoadGroupAsync();
            AssignGroupControlsValues();
        }
        private async void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            Form createExpense = new AddExpenseForm(selectedGroup.Members.FirstOrDefault(u => u.Equals(User)), selectedGroup);
            createExpense.ShowDialogAlignedWith(this);

            await RefreshGroupAsync();
        }
        private async void ImportExpensesBtn_Click(object sender, EventArgs e)
        {

            InitializeOpenFile();
            if (importExpensesOpenFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //Get the path of specified file
            var filePath = importExpensesOpenFileDialog.FileName;

            IOManager iOManager = new(selectedGroup);
            await ShowErrorOnFail(iOManager.ImportExpenses(filePath));
            await RefreshGroupAsync();
        }

        private async Task ShowErrorOnFail(Task task)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ExportExpensesBtn_Click(object sender, EventArgs e)
        {
            InitializeSaveFile();

            if (exportExpensesSaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //Get the path of specified file
            var filePath = exportExpensesSaveFileDialog.FileName;

            IOManager  iOManager = new(selectedGroup);
            await ShowErrorOnFail(iOManager.ExportExpenses(filePath));
            
        }
        private void ExportDebtsBtn_Click(object sender, EventArgs e)
        {

        }
        private void DebtsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            ListBox senderCasted = (ListBox)sender;

            //select the item under the mouse pointer
            senderCasted.SelectedIndex = senderCasted.IndexFromPoint(e.Location);
        }

        private void DebtsListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            ListBox senderCasted = (ListBox)sender;

            // context menu for listbox won't show if nothing is selected
            senderCasted.ContextMenuStrip.Visible = senderCasted.SelectedIndex != ListBox.NoMatches;
        }
        private async void DebtStripMenuItemSettle_Click(object sender, EventArgs e)
        {

            IDebt debt = (IDebt)DebtsListBox.SelectedItem;
            Form createExpense = new AddExpenseForm(debt, selectedGroup);
            createExpense.ShowDialogAlignedWith(this);

            await RefreshGroupAsync();
        }


        #endregion
        // these need to be here as they are assigned dynamicaly 
        private void InitializeOpenFile() {
            importExpensesOpenFileDialog.FileName = "";
            importExpensesOpenFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            importExpensesOpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
        private void InitializeSaveFile() {
            exportExpensesSaveFileDialog.FileName = $"Expenses-{selectedGroup}.csv";
            exportExpensesSaveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            exportExpensesSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
        
    }
}
