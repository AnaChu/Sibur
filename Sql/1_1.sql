select SUM(t.Repits) as Repits
from (select LastName, COUNT(*) as Repits from Employees 
group by LastName
having COUNT(*) > 1) as t