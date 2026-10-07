namespace G26W06WFCounter {
    public partial class Form1 : Form {
        private int count = 0;

        public Form1() {
            InitializeComponent();
        }

        private void OnAdd(object sender, EventArgs e) {
            labelCount.Text = $"{++count}";
            //labelCount.Text = (++count).ToString();
            //labelCount.Text = "" + ++count;
        }

        private void onSub(object sender, EventArgs e) {
            if (count > 0)
                labelCount.Text = $"{--count}";
        }

        private void onReset(object sender, EventArgs e) {
            count = 0;
            labelCount.Text = "0";
        }
    }
}
