-- select * from Book

-- select Book_Title, Author, NumberOfCopies from Book
--select UserName, Name from StudentLogin
--inner join Student
--on Student.SId = StudentLogin.SId

--select * From Issue

--select Name, Book_Title, IssueDate from Issue
--inner join Book
--on Book.Book_ID = Issue.Book_ID
--inner join Student
--on Student.SId = Issue.SId

select Name, NumberOfBooks from StudentLogin
inner join Student
on Student.SId = StudentLogin.SId
