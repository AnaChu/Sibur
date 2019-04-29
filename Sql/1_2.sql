select Title, COUNT(*) from Employees
where Title = 'Программист'
group by Title