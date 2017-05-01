USE Chocolate

select Bar.Name, Bar.Year, Inventor.name from Bar  right outer join Inventor on Bar.id = Inventor.BarId