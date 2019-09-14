using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuksekVeriCekmeSistemi
{
    public class syhmhfzkntlmrkz
    {
        int veri = 0;
        public Task securtylogi(ListBox lst)
        {
            return Task.Run(() =>
            {
                islembaslat(lst);
            });
        }
        void  islembaslat(ListBox lst)
        {
            for (int i = 0; i < 999999999999999; i++)
            {
                lst.Items.Add(veri);
                veri++;
            }
        }
    }
}
