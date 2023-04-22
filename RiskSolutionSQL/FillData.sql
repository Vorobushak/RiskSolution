-- Треба першим знаком в 2+ рядках поставити ;, а кодування в файлах змінити на UTF-8

CREATE DATABASE risk_database;

USE risk_database;

BULK INSERT AccessibilityViolations
FROM '/usr/src/app/scriptdata/acc.csv'
WITH (
	CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- якщо перший рядок у вашому файлі містить заголовок, вказуйте FIRSTROW = 2
);

BULK INSERT ConfidentialityViolations
FROM '/usr/src/app/scriptdata/con.csv'
WITH (
CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- якщо перший рядок у вашому файлі містить заголовок, вказуйте FIRSTROW = 2
);

BULK INSERT IntegrityViolations
FROM '/usr/src/app/scriptdata/int.csv'
WITH (
CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- якщо перший рядок у вашому файлі містить заголовок, вказуйте FIRSTROW = 2
);