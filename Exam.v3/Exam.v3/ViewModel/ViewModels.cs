using Exam.v3.Model;
using Exam.v3.Winwdows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.v3.ViewModel
{
    public class ViewModels : INotifyPropertyChanged
    {
        AppContext db;
        public Recipe SelectedItem { get; set; }
        public ObservableCollection<Recipe> Recipes { get; set; }
        public Recipe Recipe { get; set; }
        public string SearchText { get; set; }
        public ViewModels()
        {
            db = new AppContext();
            db.Recipes.Load();
            Recipes = new ObservableCollection<Recipe>(db.Recipes.Local.OrderBy(o=>o.Name).ToList());
            //сделать сортировку
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }



        // команда добавления нового объекта
        private MyCommand newRecipe;
        public MyCommand NewRecipe
        {
            get
            {
                return newRecipe ??
                  (newRecipe = new MyCommand(obj =>
                  {
                      AddRecipe add = new AddRecipe(new Recipe());
                      add.cbType.SelectedIndex = 0;
                      add.cbKitchen.SelectedIndex = 0;
                      if (add.ShowDialog() == true)
                      {
                          Recipe r = add.Recipe;
                          r.Kitchen = (string)add.cbKitchen.SelectedValue;
                          r.DishType = (string)add.cbType.SelectedValue;
                          db.Recipes.Add(r);
                          db.SaveChanges();
                          Recipes.Add(r);
                          //сделать сортировку
                          var tmp = Recipes.OrderBy(o => o.Name).ToList();
                          Recipes.Clear();
                          foreach (var item in tmp)
                              Recipes.Add(item);
                      }
                  }));
            }
        }
        // команда удаления объекта из списка
        private MyCommand delRecipe;
        public MyCommand DelRecipe
        {
            get
            {
                return delRecipe ??
                  (delRecipe = new MyCommand(selectedItem =>
                  {
                      if (selectedItem == null) return;
                      Recipe recipe = selectedItem as Recipe;
                      db.Recipes.Remove(recipe);
                      db.SaveChanges();
                      //обновить список
                      Recipes.Remove(recipe);
                  }, (obj) => SelectedItem == null ? false : true
                  ));
            }
        }
        // команда редактирования объекта из списка
        private MyCommand editRecipe;
        public MyCommand EditRecipe
        {
            get
            {
                return editRecipe ??
                  (editRecipe = new MyCommand(selectedItem =>
                  {
                      if (selectedItem == null) return;
                      Recipe recipe = selectedItem as Recipe;
                      AddRecipe add = new AddRecipe((Recipe)recipe.Clone());
                      add.cbType.SelectedValue = recipe.DishType;
                      add.cbKitchen.SelectedValue = recipe.Kitchen;
                      if (add.ShowDialog() == true)
                      {
                          int idx = Recipes.IndexOf(recipe);
                          recipe = db.Recipes.Find(add.Recipe.Id);
                          if (recipe != null)
                          {
                              recipe.Copy(add.Recipe);
                              recipe.Kitchen = (string)add.cbKitchen.SelectedValue;
                              recipe.DishType = (string)add.cbType.SelectedValue;
                              db.Entry(recipe).State = EntityState.Modified;
                              db.SaveChanges();
                              //обновить список
                              Recipes.RemoveAt(idx);
                              Recipes.Insert(idx, recipe);
                              var tmp = Recipes.OrderBy(o => o.Name).ToList();
                              Recipes.Clear();
                              foreach (var item in tmp)
                                  Recipes.Add(item);
                          }
                      }
                  }, (obj) => SelectedItem == null ? false : true
                  ));
            }
        }
        // команда блюда по категориям
        private MyCommand dishes;
        public MyCommand Dishes
        {
            get
            {
                return dishes ??
                  (dishes = new MyCommand(obj =>
                  {
                      if (obj == null) return;
                      string type = (string)obj;
                      Recipes.Clear();
                      db.Recipes.Where(r => r.DishType == type).OrderBy(o => o.Name).ToList().ForEach(x => Recipes.Add(x));
                  }
                  ));
            }
        }
        // команда все блюда
        private MyCommand all;
        public MyCommand All
        {
            get
            {
                return all ??
                  (all = new MyCommand(obj =>
                  {
                      Recipes.Clear();
                      db.Recipes.OrderBy(o => o.Name).ToList().ForEach(x => Recipes.Add(x));
                  }
                  ));
            }
        }
        // команда все блюда
        private MyCommand search;
        public MyCommand Search
        {
            get
            {
                return search ??
                  (search = new MyCommand(obj =>
                  {
                      var y = (string)obj;
                      var x = SearchText;
                      //Recipes.Clear();
                      //db.Recipes.Where(w=>w.)
                  }
                  ));
            }
        }
    }
}
