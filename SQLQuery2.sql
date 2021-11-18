ALTER PROC UserAddD

@UserName  varchar(50),
@Password  varchar(50)
AS
       INSERT INTO Table_User( UserName, Password)
       VALUES( @UserName, @Password)