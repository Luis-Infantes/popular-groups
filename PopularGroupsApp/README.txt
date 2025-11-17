##Popular Groups App##

Pequeña aplicación desarrollada con C#, ASP.NET MVC, LINQ y HTML que permite visualizar grupos de música y sus conciertos.
Al hacer clic en la imagen de cada banda, se accede a su ficha de detalles.
También se puede consultar la lista general de conciertos.
Todas las páginas están relacionadas entre sí y comparten un layout con cabecera fija.


#Estructura del Proyecto#

Modelos:

Band: representa cada grupo musical. (Relación 1--N)
Concert: representa cada concierto.


Controladores:

HomeController: vista principal (Index) y vista parcial (Details).
BandsController: vista principal (Index) y vista parcial (ConcertBands).

Layout compartido: cabecera fija para todas las vistas.



#Características#

Visualización de bandas con imágenes.
Acceso a detalles individuales.
Listado general de conciertos.
Relación 1–N entre Band y Concert.
Uso de LINQ para filtrar y ordenar datos.


#Tecnologías utilizadas#

Lenguaje: C#
Framework: ASP.NET MVC
Consultas: LINQ
Frontend: HTML 

