SELECT st.IdTeacher, t.Fio, Count(*) as studentsCount
  FROM [UniversityDB].[dbo].[Student_Teacher_Subject] st
  left join dbo.Teachers t ON t.Id = st.IdTeacher 
Group BY st.IdTeacher, t.Fio

 select *  
   FROM [UniversityDB].[dbo].[Student_Teacher_Subject] st