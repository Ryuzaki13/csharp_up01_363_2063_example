using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KFC.AppPage
{
    /// <summary>
    /// Логика взаимодействия для AppAdministrator.xaml
    /// </summary>
    public partial class Administrator : Page
    {
        public const int WIDTH = 1024;
        public const int HEIGHT = 768;

        private List<Database.Category> Categories { set; get; }
        private List<Database.Dish> Dishes { set; get; }
        private List<Database.Ingredient> Ingredients { set; get; }

        public Administrator()
        {
            InitializeComponent();
        }

        public void Setup(AppWindow wnd)
        {
            wnd.Title = "KFC - администратор";
            wnd.MaxWidth = 0;
            wnd.MaxHeight = 0;
            wnd.Width = WIDTH;
            wnd.Height = HEIGHT;

            Lib.Placeholder.SetElement(DishName, "dish-name", "Название блюда");
            Lib.Placeholder.SetElement(Price, "dish-price", "Цена");

            BuildCategoryList();
            BuildDishList();
            BuildIngredientList();

            CategoryList.DisplayMemberPath = "Name";
            //DishList.DisplayMemberPath = "Name";
            IngredientList.DisplayMemberPath = "Name";
        }

        public void BuildCategoryList()
        {
            Categories = AppWindow.Connection.Category.OrderBy(c => c.Name).ToList();

            CategoryList.Items.Clear();
            foreach (var category in Categories)
            {
                CategoryList.Items.Add(category);
            }
        }

        public void BuildDishList()
        {
            if (CategoryList.SelectedIndex == -1) return;

            string categoryName = ((Database.Category)CategoryList.SelectedItem).Name;
            Dishes = AppWindow.Connection.Dish.Where(d => d.Category == categoryName).OrderBy(d => d.Name).ToList();

            DishList.Items.Clear();
            foreach (var dish in Dishes)
            {
                DishList.Items.Add(dish);
            }
        }

        public void BuildIngredientList()
        {
            Ingredients = AppWindow.Connection.Ingredient.OrderBy(d => d.Name).ToList();

            IngredientList.Items.Clear();
            foreach (var ingredient in Ingredients)
            {
                IngredientList.Items.Add(ingredient);
            }
        }

        private void OnAddCategory(object sender, RoutedEventArgs e)
        {
            if (CategoryName.Text.Length > 0)
            {
                Database.Category category = new Database.Category
                {
                    Name = CategoryName.Text
                };

                if (Find(CategoryName.Text) != null)
                {
                    MessageBox.Show("Категория с таким именем уже существует", "ВНИМАНИЕ!");
                    return;
                }

                AppWindow.Connection.Category.Add(category);
                AppWindow.Connection.SaveChanges();

                BuildCategoryList();

                CategoryName.Text = "";
            }
            else
            {
                MessageBox.Show("Необходимо ввести название категории", "ВНИМАНИЕ");
            }
        }

        private void OnAddIngredient(object sender, RoutedEventArgs e)
        {
            if (IngredientName.Text.Length == 0 || IngredientCalory.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены", "ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                Database.Ingredient ingredient = new Database.Ingredient();
                ingredient.Name = IngredientName.Text;
                ingredient.Calory = int.Parse(IngredientCalory.Text);

                AppWindow.Connection.Ingredient.Add(ingredient);
                AppWindow.Connection.SaveChanges();

                IngredientName.Text = "";
                IngredientCalory.Text = "";

                BuildIngredientList();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private Database.Category Find(string categoryName)
        {
            foreach (var category in Categories)
            {
                if (category.Name == categoryName)
                {
                    return category;
                }
            }
            return null;
        }

        private void OnDeleteCategory(object sender, RoutedEventArgs e)
        {
            var selectedCategory = CategoryList.SelectedItem as Database.Category;
            if (selectedCategory != null)
            {
                AppWindow.Connection.Category.Remove(selectedCategory);
                AppWindow.Connection.SaveChanges();
                BuildCategoryList();
            }
        }

        private void OnAddDish(object sender, RoutedEventArgs e)
        {
            if (CategoryList.SelectedIndex == -1 || DishName.Text.Length == 0 || Price.Text.Length == 0)
            {
                MessageBox.Show("Необходимо выбрать категорию и заполнить поля", "ВНИМАНИЕ!");
                return;
            }

            try
            {
                Database.Dish dish = new Database.Dish();
                dish.Name = DishName.Text;
                dish.Price = decimal.Parse(Price.Text);
                dish.Category = ((Database.Category)CategoryList.SelectedItem).Name;

                AppWindow.Connection.Dish.Add(dish);
                AppWindow.Connection.SaveChanges();

                BuildDishList();

                DishName.Text = "";
                Price.Text = "";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "ОШИБКА");
            }
        }

        private void CategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ButtonDeleteCategory.IsEnabled = CategoryList.SelectedIndex != -1;
            ButtonAddDish.IsEnabled = CategoryList.SelectedIndex != -1;

            BuildDishList();
        }

        private void DishList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonDeleteDish.IsEnabled = DishList.SelectedIndex != -1;
        }
    }
}
