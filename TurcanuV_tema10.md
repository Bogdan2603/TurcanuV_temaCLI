# TurcanuV_tema10

1. Utilizați pentru texturare imagini cu transparență și fără. Ce observați?

Texturile cu transparență permit vizualizarea parțială a obiectului texturat sau a fundalului. Sunt folosite la  crearea de efecte reale : geamurile, frunzele, obiecte transparente.

Texturile fără transparență acoperă complet obiectul texturat, oferind un aspect solid.

Pot apărea probleme dacă nu se ține cont de ordinea de desenare a obectilor cu textură cu transparență deoarece nu este gestionată automat de OpenGL.

1. Ce formate de imagine pot fi aplicate în procesul de texturare în
OpenGL?
    
    JPEG, PNG, BMP, TGA, DDS
    

1. Specificați ce se întâmplă atunci când se modifică culoarea (prin
manipularea canalelor RGB) obiectului texturat.
    
    Rezultatul obținut depinde de modul de texturare:
    
    Modulație. Culoarea obiectului se combină cu textura. Se schimbă nuanța,luminozitatea culorii.
    
    Decal. Culoarea texturii este aplicată peste culoarea obiectului. Este văzută doar atunci când obiectului ii se aplică transparența
    
    Replace. Culoarea obiectului nu este văzută, chiar dacă textura are proprietatea de transparență
    
2. Ce deosebiri există între scena ce utilizează obiecte texturate în modul
iluminare activat, respectiv dezactivat?

Iluminare dezactivată:

Textura este afișată ca o imagine „plată” pe obiect, fără variații de luminozitate sau umbre.

Iluminare activată:

Lumina interacționează cu textura, rezultând efecte de umbre, reflexii și variații de intensitate. Texturile pot apărea diferit în funcție de unghiul de iluminare și proprietățile materialului.