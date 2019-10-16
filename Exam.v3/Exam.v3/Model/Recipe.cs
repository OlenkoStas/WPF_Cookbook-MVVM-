using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exam.v3.Model
{
    public class Recipe : INotifyPropertyChanged//,ICloneable
    {
        private string _name;
        private string _instruction;
        private string _ingredients;
        private string _photo = "";
        private string _kitchen;
        private string _dishType;

        public int Id { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                if (!value.Equals(_name))
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Instruction
        {
            get => _instruction;
            set
            {
                if (!value.Equals(_instruction))
                {
                    _instruction = value;
                    OnPropertyChanged(nameof(Instruction));
                }
            }
        }
        public string Ingredients
        {
            get => _ingredients;
            set
            {
                if (!value.Equals(_ingredients))
                {
                    _ingredients = value;
                    OnPropertyChanged(nameof(Ingredients));
                }
            }
        }
        public string Photo
        {
            get => _photo;
            set
            {
                if (!value.Equals(_photo))
                {
                    _photo = value;
                    OnPropertyChanged(nameof(Photo));
                }
            }
        }
        public string Kitchen
        {
            get => _kitchen;
            set
            {
                if (!value.Equals(_kitchen))
                {
                    _kitchen = value;
                    OnPropertyChanged(nameof(Kitchen));
                }
            }
        }
        public string DishType
        {
            get => _dishType;
            set
            {
                if (!value.Equals(_dishType))
                {
                    _dishType = value;
                    OnPropertyChanged(nameof(DishType));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        

        /// <summary>
        /// Загрузка всех рецептов
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Recipe> Load()
        {
            string DirName = "Recipes";
            string FileName = "AllRecipes";
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<Recipe>));
            string path = $"{Directory.GetCurrentDirectory()}\\{DirName}\\{FileName}.xml";
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    return (ObservableCollection<Recipe>)xml.Deserialize(fs);
                }
            }
            return null;
        }
        /// <summary>
        /// Сохранение все рецептов
        /// </summary>
        public static void Save(ObservableCollection<Recipe> recipes)
        {
            string DirName = "Recipes";
            string FileName = "AllRecipes";
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<Recipe>));
            if (!Directory.Exists(DirName))
                Directory.CreateDirectory(DirName);
            using (FileStream fs = new FileStream($"{Directory.GetCurrentDirectory()}\\{DirName}\\{FileName}.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                xml.Serialize(fs, recipes);
            }
        }

        public object Clone()
        {
            return new Recipe()
            {
                Id=this.Id,
                Name = this.Name,
                Ingredients = this.Ingredients,
                Instruction = this.Instruction,
                Kitchen = this.Kitchen,
                Photo = this.Photo
            };
        }
        public void Copy(Recipe r)
        {
            this.Id = r.Id;
            this.Name = r.Name;
            this.Ingredients = r.Ingredients;
            this.Instruction = r.Instruction;
            this.Kitchen = r.Kitchen;
            this.Photo = r.Photo;
        }
    }
}
