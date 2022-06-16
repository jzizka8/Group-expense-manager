namespace Project.UI
{
    public static class FormExtensions
    {
        public static void ShowDialogAlignedWith(this Form newForm, Form current)
        {
            newForm.AlignWith(current);
            newForm.ShowDialog();
        }

        public static void AlignWith(this Form newForm, Form current)
        {
            newForm.Location = current.Location;
            newForm.StartPosition = FormStartPosition.Manual;
        }

        public static void ReplaceCurrentWith(this Form current, Form newForm)
        {
            newForm.AlignWith(current);

            newForm.FormClosing += delegate { current.Show(); };
            newForm.Show();
            current.Hide();
        }
    }
}
