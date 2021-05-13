CREATE TABLE employees (
    employee_id   NUMERIC       NOT NULL,
    first_name    VARCHAR(1000) NOT NULL,
    last_name     VARCHAR(900)  NOT NULL,
    date_of_birth DATE                   ,
    phone_number  VARCHAR(1000) NOT NULL,
    junk          CHAR(1000)             ,
    CONSTRAINT employees_pk
       PRIMARY KEY NONCLUSTERED (employee_id)
);
GO
IF OBJECT_ID('rand_helper') IS NOT NULL
   DROP VIEW rand_helper;
GO

CREATE VIEW rand_helper AS SELECT RND=RAND();
GO
IF OBJECT_ID('random_string') IS NOT NULL
   DROP FUNCTION random_string;
GO

CREATE FUNCTION random_string (@maxlen int)
   RETURNS VARCHAR(255)
AS BEGIN
   DECLARE @rv VARCHAR(255)
   DECLARE @loop int
   DECLARE @len int

   SET @len = (SELECT CAST(rnd * (@maxlen-3) AS INT) + 3
                 FROM rand_helper)
   SET @rv = ''
   SET @loop = 0

   WHILE @loop < @len BEGIN
      SET @rv = @rv 
              + CHAR(CAST((SELECT rnd * 26
                             FROM rand_helper) AS INT )+97)
      IF @loop = 0 BEGIN
          SET @rv = UPPER(@rv)
      END
      SET @loop = @loop +1;
   END

   RETURN @rv
END
GO
IF OBJECT_ID('random_date') IS NOT NULL
   DROP FUNCTION random_date;
GO

CREATE FUNCTION random_date (@mindays int, @maxdays int) 
   RETURNS VARCHAR(255)
AS BEGIN
   DECLARE @rv date
   SET @rv = (SELECT GetDate() 
                   - rnd * (@maxdays-@mindays)
                   - @mindays
                FROM rand_helper)
   RETURN @rv
END
GO
IF OBJECT_ID('random_int') IS NOT NULL
   DROP FUNCTION random_int;
GO

CREATE FUNCTION random_int (@min int, @max int)
   RETURNS INT
AS BEGIN
   DECLARE @rv INT
   SET @rv = (SELECT rnd * (@max) + @min
                FROM rand_helper)
   RETURN @rv
END
GO
WITH generator (n) AS
( SELECT 1
   UNION ALL
  SELECT n + 1 FROM generator
WHERE n < 1000
)
INSERT INTO employees (employee_id
                     , first_name, last_name
                     , date_of_birth, phone_number, junk)
select n employee_id
     , [dbo].random_string(11) first_name
     , [dbo].random_string(11) last_name  
     , [dbo].random_date(20*365, 60*365) dob
     , 'N/A' phone
     , 'junk' junk
  from generator
OPTION (MAXRECURSION 1000)
GO
UPDATE employees 
   SET first_name='Markus', 
       last_name='Winand'
 WHERE employee_id=123;

exec sp_updatestats;
GO
