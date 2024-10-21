# ȚurcanuV_tema01

1. Puncte slabe / puternice a tehnologiei OpenGL
2. Modelul de automat cu stări finite al OpenGL - afectarea procesului de randare al scenei 3D de catre bibl. graf./API.

1. 

> PUNCTE PUTERNICE (OpenGL)
> 
> - open-source
> - cross-platform
> - Poate fi implementată prin mai multe limbaje populare

> PUNCTE PUTERNICE (Vulkan)
> 
> - open-source
> - cross-platform
> - Performanțe mai înalte la plăcile moderne, dar nu se aplică beneficiul la plăcile vechi

> PUNCTE PUTERNICE (Metal)
> 
> - Performanțe mai înalte, dar exclusiv ecosistemei Apple.

> PUNCTE PUTERNICE (DirectX)
> 
> - Performanțele pot fi mai  înalte în comparație cu OpenGL, dar exclusiv SO Windows și XBOX.

> PUNCTE SLABE
> 
> - Dificultatea destul de înaltă, în special programatorilor începători
> - Sunt alternative cu o performanță mai bună ( ex. Vulkan sau Directx )
> - Nu este integrată din start multithreading-ul, ce este un minus foarte mare, având în vedere ca procesoarele moderne sunt încorporate cu 6-8 nuclee și mai mult.

b. 

> OpenGL este un atomat cu stări finite , unde fiecare stare definește un set de procese ce definește regulile de prelucrare a datelor grafice. Tranzițiile între stări sunt apelate de funcțiile solicitate de programator
> 

> AFECTAREA PROCESULUI DE RANDARE
> 
> - Starea următoare depinde de starile curente. Dacă ele se schimb prea des, pot duce la o supraâcărcare și încetinirea execuției.
> - Predictibilitatea procesului de randare
> - Procesul de randare oferă o configurabilitate ușoară. Pot fi schimbate diferite parametri a entităților din scenă prin modificarea stărilor.