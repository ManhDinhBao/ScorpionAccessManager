using ScorpionAccessManager.Model;
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

namespace ScorpionAccessManager.View
{
    /// <summary>
    /// Interaction logic for ucCard.xaml
    /// </summary>
    public partial class CardModel : UserControl
    {
        private Card currentCard;
        private string cardHolderName;
        public CardModel()
        {
            InitializeComponent();
        }

        public CardModel(Card card, string cardHolderName)
        {
            currentCard = card;
            this.cardHolderName = cardHolderName;
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            tbCardNumber.Text = currentCard.Number;
            tbCardDate.Text = GenCardDate(currentCard.StartTime, currentCard.EndTime);
            tbCardHolder.Text = this.cardHolderName.ToUpper();
        }

        private string GenCardDate(DateTime startDate, DateTime endDate)
        {
            string result = "";
            result += startDate.Month.ToString() + "/" + startDate.Year.ToString();
            result += " - " + endDate.Month.ToString() + "/" + endDate.Year.ToString();

            return result;
        }
    }
}
