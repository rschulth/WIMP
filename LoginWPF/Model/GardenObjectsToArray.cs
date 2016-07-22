using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using LoginWPF.json;

namespace LoginWPF.Model
{
    public static class GardenObjectsToArray
    {

        public static int[] getArray(Garden garden)
        {
            
                List<Object[]> list = new List<object[]>();
                list.Add(garden.object1);
                list.Add(garden.object2);
                list.Add(garden.object3);
                list.Add(garden.object4);
                list.Add(garden.object5);
                list.Add(garden.object6);
                list.Add(garden.object7);
                list.Add(garden.object8);
                list.Add(garden.object9);
                list.Add(garden.object10);
                list.Add(garden.object11);
                list.Add(garden.object12);
                list.Add(garden.object13);
                list.Add(garden.object14);
                list.Add(garden.object15);
                list.Add(garden.object16);
                list.Add(garden.object17);
                list.Add(garden.object18);
                list.Add(garden.object19);
                list.Add(garden.object20);
                list.Add(garden.object21);
                list.Add(garden.object22);
                list.Add(garden.object23);
                list.Add(garden.object24);
                list.Add(garden.object25);
                list.Add(garden.object26);
                list.Add(garden.object27);
                list.Add(garden.object28);
                list.Add(garden.object29);
                list.Add(garden.object30);
                list.Add(garden.object31);
                list.Add(garden.object32);
                list.Add(garden.object33);
                list.Add(garden.object34);
                list.Add(garden.object35);
                list.Add(garden.object36);
                list.Add(garden.object37);
                list.Add(garden.object38);
                list.Add(garden.object39);
                list.Add(garden.object40);
                list.Add(garden.object41);
                list.Add(garden.object42);
                list.Add(garden.object43);
                list.Add(garden.object44);
                list.Add(garden.object45);
                list.Add(garden.object46);
                list.Add(garden.object47);
                list.Add(garden.object48);
                list.Add(garden.object49);
                list.Add(garden.object50);
                list.Add(garden.object51);
                list.Add(garden.object52);
                list.Add(garden.object53);
                list.Add(garden.object54);
                list.Add(garden.object55);
                list.Add(garden.object56);
                list.Add(garden.object57);
                list.Add(garden.object58);
                list.Add(garden.object59);
                list.Add(garden.object60);
                list.Add(garden.object61);
                list.Add(garden.object62);
                list.Add(garden.object63);
                list.Add(garden.object64);
                list.Add(garden.object65);
                list.Add(garden.object66);
                list.Add(garden.object67);
                list.Add(garden.object68);
                list.Add(garden.object69);
                list.Add(garden.object70);
                list.Add(garden.object71);
                list.Add(garden.object72);
                list.Add(garden.object73);
                list.Add(garden.object74);
                list.Add(garden.object75);
                list.Add(garden.object76);
                list.Add(garden.object77);
                list.Add(garden.object78);
                list.Add(garden.object79);
                list.Add(garden.object80);
                list.Add(garden.object81);
                list.Add(garden.object82);
                list.Add(garden.object83);
                list.Add(garden.object84);
                list.Add(garden.object85);
                list.Add(garden.object86);
                list.Add(garden.object87);
                list.Add(garden.object88);
                list.Add(garden.object89);
                list.Add(garden.object90);
                list.Add(garden.object91);
                list.Add(garden.object92);
                list.Add(garden.object93);
                list.Add(garden.object94);
                list.Add(garden.object95);
                list.Add(garden.object96);
                list.Add(garden.object97);
                list.Add(garden.object98);
                list.Add(garden.object99);
                list.Add(garden.object100);
                list.Add(garden.object101);
                list.Add(garden.object102);
                list.Add(garden.object103);
                list.Add(garden.object104);
                list.Add(garden.object105);
                list.Add(garden.object106);
                list.Add(garden.object107);
                list.Add(garden.object108);
                list.Add(garden.object109);
                list.Add(garden.object110);
                list.Add(garden.object111);
                list.Add(garden.object112);
                list.Add(garden.object113);
                list.Add(garden.object114);
                list.Add(garden.object115);
                list.Add(garden.object116);
                list.Add(garden.object117);
                list.Add(garden.object118);
                list.Add(garden.object119);
                list.Add(garden.object120);
                list.Add(garden.object121);
                list.Add(garden.object122);
                list.Add(garden.object123);
                list.Add(garden.object124);
                list.Add(garden.object125);
                list.Add(garden.object126);
                list.Add(garden.object127);
                list.Add(garden.object128);
                list.Add(garden.object129);
                list.Add(garden.object130);
                list.Add(garden.object131);
                list.Add(garden.object132);
                list.Add(garden.object133);
                list.Add(garden.object134);
                list.Add(garden.object135);
                list.Add(garden.object136);
                list.Add(garden.object137);
                list.Add(garden.object138);
                list.Add(garden.object139);
                list.Add(garden.object140);
                list.Add(garden.object141);
                list.Add(garden.object142);
                list.Add(garden.object143);
                list.Add(garden.object144);
                list.Add(garden.object145);
                list.Add(garden.object146);
                list.Add(garden.object147);
                list.Add(garden.object148);
                list.Add(garden.object149);
                list.Add(garden.object150);
                list.Add(garden.object151);
                list.Add(garden.object152);
                list.Add(garden.object153);
                list.Add(garden.object154);
                list.Add(garden.object155);
                list.Add(garden.object156);
                list.Add(garden.object157);
                list.Add(garden.object158);
                list.Add(garden.object159);
                list.Add(garden.object160);
                list.Add(garden.object161);
                list.Add(garden.object162);
                list.Add(garden.object163);
                list.Add(garden.object164);
                list.Add(garden.object165);
                list.Add(garden.object166);
                list.Add(garden.object167);
                list.Add(garden.object168);
                list.Add(garden.object169);
                list.Add(garden.object170);
                list.Add(garden.object171);
                list.Add(garden.object172);
                list.Add(garden.object173);
                list.Add(garden.object174);
                list.Add(garden.object175);
                list.Add(garden.object176);
                list.Add(garden.object177);
                list.Add(garden.object178);
                list.Add(garden.object179);
                list.Add(garden.object180);
                list.Add(garden.object181);
                list.Add(garden.object182);
                list.Add(garden.object183);
                list.Add(garden.object184);
                list.Add(garden.object185);
                list.Add(garden.object186);
                list.Add(garden.object187);
                list.Add(garden.object188);
                list.Add(garden.object189);
                list.Add(garden.object190);
                list.Add(garden.object191);
                list.Add(garden.object192);
                list.Add(garden.object193);
                list.Add(garden.object194);
                list.Add(garden.object195);
                list.Add(garden.object196);
                list.Add(garden.object197);
                list.Add(garden.object198);
                list.Add(garden.object199);
                list.Add(garden.object200);
                list.Add(garden.object201);
                list.Add(garden.object202);
                list.Add(garden.object203);
                list.Add(garden.object204);

            int[] array = new int[260]; //250

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }

            foreach (var o in list)
            {
                int n = (int) o[0];

                array[n]++;
            }
            return array;
        }

    }
}
