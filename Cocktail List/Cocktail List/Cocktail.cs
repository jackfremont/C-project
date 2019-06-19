using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktail_List
{


    class Cocktail
    {
        private List<Cocktail> Cocktails = new List<Cocktail>();


        #region Properties


        public string Picturelink { get; set; }

        public string Name { get; set; }

        public Array IngredientList { get; set; }

        public DateTime InputDate { get; private set; }

        public int Rating { get; set; }
        #endregion

    }

    
}
