namespace notepad
{
    public partial class FindForm : Form
    {
        /// <summary>
        /// Текст для поиска
        /// </summary>
        public string FindText
        {
            get => txtFind.Text;
            set => txtFind.Text = value;
        }

        /// <summary>
        /// Условия поиска
        /// </summary>
        public RichTextBoxFinds FindCondition
        {
            get
            {
                var result = RichTextBoxFinds.None;
                if (cbMatchCase.Checked)
                {
                    result |= RichTextBoxFinds.MatchCase;
                }
                if (cbMatchWhole.Checked)
                {
                    result |= RichTextBoxFinds.WholeWord;
                }
                return result;
            }
        }

        public FindForm()
        {
            InitializeComponent();
        }
    }
}
