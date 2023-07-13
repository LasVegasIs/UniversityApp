SELECT st.IdTeacher, t.Fio, st.IdSubject, s.Title, Count(*) as studentsCount
  FROM [UniversityDB].[dbo].[Student_Teacher_Subject] st
  left join dbo.Teachers t ON t.Id = st.IdTeacher 
  left join dbo.Subjects s ON s.Id = st.IdSubject
Group BY st.IdTeacher, t.Fio, st.IdSubject, s.Title


  select *  
   FROM [UniversityDB].[dbo].[Student_Teacher_Subject] st