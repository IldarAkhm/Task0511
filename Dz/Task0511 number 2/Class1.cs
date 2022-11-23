using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Boris { } //Глава всего
    class Rashid : Boris { } //Глава бухгалетрии, снизу подчиненные
    class Finance : Rashid { }
    class Lukas : Finance { }

    class OIlham : Boris { } //Глава автоматизации, снизу подчиненные
    class AutomatizationSystem : OIlham { }
    class Orcadiy : OIlham { }//Глава информациионных систем, снизу подчиненные
    class InformationSystem : Orcadiy { }
    class Volodya : Orcadiy { }

    class Ilshat : Volodya { } //Главна Систематизации
    class Systematization : Ilshat { }
    class Ivanich : Systematization { }
    class Ilya : Ivanich { }
    class Vitya : Ivanich { }
    class Jeka : Ivanich { }



    class Sergey : Volodya { } //Глава разработка
    class Develop : Sergey { }
    class Lyaisan : Develop { }
    class Marat : Lyaisan { }
    class Dina : Lyaisan { }
    class Ildar : Lyaisan { }
    class Anton : Lyaisan { }
}
