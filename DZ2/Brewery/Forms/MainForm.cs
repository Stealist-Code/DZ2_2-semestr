using Brewery.Classes;
using Brewery.ContextDataBase;
using Brewery.Enums;
using Brewery.ServiceClasses;
using System.Data;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Xml.Serialization;

namespace Brewery.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            brewery_ComboBoxLoadData();
            WorkToNode();
        }

        private void mainForm_DataLoadBeers(Beer beerImport = null)
        {
            var table = new DataTable();

            dataGridView1.DataSource = null;

            var beerImportNull = false;
            table.Columns.Add("Название", typeof(string));
            table.Columns.Add("Содержание алкоголя (%)", typeof(double));
            table.Columns.Add("Сорт пива", typeof(BeerType));

            if (beerImport is null)
            {
                foreach (var beer in Data.Beers)
                {
                    table.Rows.Add(beer.Name, beer.AlcoholPercentage, beer.BeerType);
                    beerImportNull = true;
                }
            }
            else
            {
                table.Rows.Add(beerImport.Name, beerImport.AlcoholPercentage, beerImport.BeerType);
            }

            dataGridView1.DataSource = table;

            if (beerImportNull)
            {
                for (var i = 0; i < Data.Beers.Count; i++)
                {
                    dataGridView1.Rows[i].Tag = Data.Beers[i];
                }
            }
            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Tag = beerImport;
                }
            }
        }

        private void mainForm_DataLoadIngredients(StockIngredient stockIngredientImport = null)
        {

            var table = new DataTable();

            var stockIngredientImportNull = false;
            table.Columns.Add("Название", typeof(string));
            table.Columns.Add("Количество", typeof(int));

            if (stockIngredientImport is null)
            {
                foreach (var stockIngredient in Data.StockIngredients)
                {
                    table.Rows.Add(stockIngredient.Ingredient.Name, stockIngredient.Quantity);
                    stockIngredientImportNull = true;
                }
            }
            else
            {
                table.Rows.Add(stockIngredientImport.Ingredient.Name, stockIngredientImport.Quantity);
            }

            dataGridView1.DataSource = table;

            if (stockIngredientImportNull)
            {
                for (var i = 0; i < Data.StockIngredients.Count; i++)
                {
                    dataGridView1.Rows[i].Tag = Data.StockIngredients[i];
                }
            }
            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Tag = stockIngredientImport;
                }
            }
        }

        private void mainForm_DataLoadRecipes(Recipe recipeImport = null)
        {
            var table = new DataTable();

            var recipeImportNull = false;
            table.Columns.Add("Название Рецепта", typeof(string));
            table.Columns.Add("Название Пива", typeof(string));
            table.Columns.Add("Сорт пива", typeof(BeerType));
            table.Columns.Add("Ингредиенты", typeof(string));

            if (recipeImport is null)
            {
                foreach (var recipe in Data.Recipes)
                {
                    var row = table.Rows.Add(recipe.Name, recipe.NameBeer, recipe.BeerType, string.Join("\n", recipe.Ingredients.Select(p => $"{p.Key.Name} : {p.Value} {p.Key.UnitMeasurement}")));
                }
                recipeImportNull = true;
            }
            else
            {
                table.Rows.Add(recipeImport.Name, recipeImport.NameBeer, recipeImport.BeerType, string.Join("\n", recipeImport.Ingredients.Select(p => $"{p.Key.Name} : {p.Value} {p.Key.UnitMeasurement}")));
            }
            dataGridView1.DataSource = table;

            if (recipeImportNull)
            {
                for (var i = 0; i < Data.Recipes.Count; i++)
                {
                    dataGridView1.Rows[i].Tag = Data.Recipes[i];
                }
            }
            else
            {
                dataGridView1.Rows[0].Tag = recipeImport;
            }
        }

        private void WorkToNode()
        {
            mainTreeView.Nodes["BeerNode"].Nodes.Clear();
            mainTreeView.Nodes["RecipeNode"].Nodes.Clear();
            mainTreeView.Nodes["IngredientNode"].Nodes.Clear();

            foreach (var beer in Data.Beers)
            {
                var treeNode = new TreeNode(beer.Name);
                treeNode.Tag = beer;
                mainTreeView.Nodes["BeerNode"].Nodes.Add(treeNode);
            }

            foreach (var recipe in Data.Recipes)
            {
                var treeNode = new TreeNode(recipe.Name);
                treeNode.Tag = recipe;
                mainTreeView.Nodes["RecipeNode"].Nodes.Add(treeNode);
            }

            foreach (var stockIngredient in Data.StockIngredients)
            {
                var treeNode = new TreeNode(stockIngredient.Ingredient.Name);
                treeNode.Tag = stockIngredient;
                mainTreeView.Nodes["IngredientNode"].Nodes.Add(treeNode);
            }
        }

        private void mainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0 && e.Node.Name == "BeerNode")
            {
                mainForm_DataLoadBeers();
            }

            else if (e.Node.Level == 0 && e.Node.Name == "RecipeNode")
            {
                mainForm_DataLoadRecipes();
            }

            else if (e.Node.Level == 0 && e.Node.Name == "IngredientNode")
            {
                mainForm_DataLoadIngredients();
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Name == "BeerNode")
            {
                mainForm_DataLoadBeers(e.Node.Tag as Beer);
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Name == "RecipeNode")
            {
                mainForm_DataLoadRecipes(e.Node.Tag as Recipe);
            }

            else if (e.Node.Level == 1 && e.Node.Parent.Name == "IngredientNode")
            {
                mainForm_DataLoadIngredients(e.Node.Tag as StockIngredient);
            }
        }

        private void brewery_ComboBoxLoadData()
        {
            comboBoxRecipe.Items.Clear();
            foreach (var recipe in Data.Recipes)
            {
                comboBoxRecipe.Items.Add(recipe.Name);
            }
        }

        private void экспортВJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.Cyrillic, UnicodeRanges.BasicLatin) };
            options.Converters.Add(new IngredientConverter());
            var beersList = Data.Beers.ToList();
            var json = JsonSerializer.Serialize(beersList, options);
            try
            {
                File.WriteAllText(@"..\..\..\Files\ExportBeer.json", json);
                MessageBox.Show("Успешно. Данные о пивах экспортировались");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Данные не экспортировались.");
            }

        }

        private void экспортВXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var beersList = Data.Beers;
            var xmlSerializer = new XmlSerializer(typeof(List<StockIngredient>));

            try
            {
                using (FileStream fileStream = new FileStream(@"..\..\..\Files\ExportBeer.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fileStream, beersList);
                }
                MessageBox.Show("Успешно.");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Данные не экспортировались.");
            }
        }

        private void buttonStartBrew_Click(object sender, EventArgs e)
        {
            var textFromComboBox = comboBoxRecipe.Text;

            if (textFromComboBox is not null)
            {
                var recipe = Data.Recipes.FirstOrDefault(i => textFromComboBox == i.Name);

                if (recipe is not null)
                {
                    var breweryService = new BreweryService();
                    if (breweryService.Brew(recipe))
                    {
                        MessageBox.Show($"Успешно. Сварилось пиво: {recipe.NameBeer}, с крепкостью: {recipe.AlcoholPercentage} %");
                        WorkToNode();
                        mainForm_DataLoadIngredients();
                        mainForm_DataLoadBeers();
                        return;
                    }
                }
            }
            MessageBox.Show("Неудачно");
        }

        private void импортИнгредиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importOpenFileDialog.Filter = "JSON files(*.json)|*.json|XML files(*.xml)|*.xml";

            if (importOpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                List<StockIngredient>? stockIngredients = null;

                var filename = importOpenFileDialog.FileName;
                var extension = Path.GetExtension(filename);
                if (extension == ".json")
                {
                    ImportDataFromJSON(filename, out stockIngredients);
                }
                else if (extension == ".xml")
                {
                    ImportDataFromXML(filename, out stockIngredients);
                }

                var count = 0;

                if (stockIngredients is not null && Data.StockIngredients is not null)
                {
                    foreach (var stockIngredient in stockIngredients)
                    {
                        if (stockIngredient.Ingredient == null)
                        {
                            continue;
                        }

                        var existingStockIngredient = Data.StockIngredients.FirstOrDefault(i => i.Ingredient.Id == stockIngredient.Ingredient.Id && i.Ingredient.Name == stockIngredient.Ingredient.Name);

                        if (existingStockIngredient is not null)
                        {
                            count++;
                            existingStockIngredient.Quantity += stockIngredient.Quantity;
                        }
                        else
                        {
                            count++;
                            Data.StockIngredients.Add(stockIngredient);
                        }
                    }
                    if (count == 0)
                    {
                        throw new Exception("Неправильные данные");
                    }
                }
                WorkToNode();
                mainForm_DataLoadIngredients();
                MessageBox.Show("Успешно. Ингредиенты добавлены.");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Данные не импортировались.");
            }
        }

        private void импортРецептовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importOpenFileDialog.Filter = "JSON files(*.json)|*.json";

            if (importOpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                var filename = importOpenFileDialog.FileName;
                var fileText = File.ReadAllText(filename);

                var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.Cyrillic, UnicodeRanges.BasicLatin) };
                options.Converters.Add(new IngredientConverter());

                List<Recipe>? recipes = JsonSerializer.Deserialize<List<Recipe>>(fileText, options);

                var count = 0;

                if (recipes is not null)
                {
                    foreach (var recipe in recipes)
                    {
                        if (recipe.Name is null)
                        {
                            continue;
                        }
                        var existingRecipe = Data.Recipes.FirstOrDefault(i => i.Id == recipe.Id);

                        if (existingRecipe is null)
                        {
                            count++;
                            Data.Recipes.Add(recipe);
                        }
                    }
                    if (count == 0)
                    {
                        throw new Exception("Неправильные данные");
                    }
                }
                WorkToNode();
                brewery_ComboBoxLoadData();
                mainForm_DataLoadRecipes();
                MessageBox.Show("Успешно. Рецепты добавлены.");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Данные не импортировались.");
            }
        }

        private void ImportDataFromXML(string filename, out List<StockIngredient>? stockIngredients)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<StockIngredient>));

            using (FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                stockIngredients = xmlSerializer.Deserialize(fileStream) as List<StockIngredient>;
            }
        }

        private void ImportDataFromJSON(string filename, out List<StockIngredient>? stockIngredients)
        {
            var fileText = File.ReadAllText(filename);

            stockIngredients = JsonSerializer.Deserialize<List<StockIngredient>>(fileText);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                var selectedObject = selectedRow.Tag;

                if (selectedObject is null)
                {
                    return;
                }

                var descriptionForm = new DescriptionForm(selectedObject);
                descriptionForm.ShowDialog();
            }
        }
    }
}
