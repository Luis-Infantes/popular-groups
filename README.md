##Popular Groups App##
A small application developed with C#, ASP.NET MVC, LINQ, and HTML that allows you to view music bands and their concerts.
By clicking on the image of each band, you can access its detail page.
You can also check the general list of concerts.
All pages are interconnected and share a layout with a fixed header.

#Project Structure#
Models:

Band: Represents each music group. (One-to-Many relationship)
Concert: Represents each concert.

Controllers:

HomeController: Main view (Index) and partial view (Details).
BandsController: Main view (Index) and partial view (ConcertBands).

Shared Layout: Fixed header for all views.

#Features#

Display bands with images.
Access individual details.
General concert listing.
One-to-Many relationship between Band and Concert.
Use of LINQ to filter and sort data.


#Technologies Used#

Language: C#
Framework: ASP.NET MVC
Queries: LINQ
Frontend: HTML
