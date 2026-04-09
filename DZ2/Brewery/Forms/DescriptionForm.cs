namespace Brewery.Forms
{
    public partial class DescriptionForm : Form
    {
        public DescriptionForm(object data)
        {
            InitializeComponent();
            propertyGrid1.PropertySort = PropertySort.Alphabetical;
            propertyGrid1.SelectedObject = data;
        }
    }
}
