-- Треба першим знаком в 2+ рядках поставити ;, а кодування в файлах змінити на UTF-8

BULK INSERT AccessibilityViolations
FROM 'C:\RiskData\acc.csv'
WITH (
	CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- якщо перший рядок у вашому файлі містить заголовок, вказуйте FIRSTROW = 2
);

BULK INSERT ConfidentialityViolations
FROM 'C:\RiskData\con.csv'
WITH (
CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- якщо перший рядок у вашому файлі містить заголовок, вказуйте FIRSTROW = 2
);

BULK INSERT IntegrityViolations
FROM 'C:\RiskData\int.csv'
WITH (
CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- якщо перший рядок у вашому файлі містить заголовок, вказуйте FIRSTROW = 2
);