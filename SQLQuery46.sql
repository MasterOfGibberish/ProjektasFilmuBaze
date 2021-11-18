
ALTER PROC Login_Table_ADD
@UserName  varchar(50),
@Password  varchar(50)
AS
       INSERT INTO Login_Table( UserName, Password)
       VALUES(@UserName, @Password)