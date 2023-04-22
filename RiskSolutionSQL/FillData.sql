-- ����� ������ ������ � 2+ ������ ��������� ;, � ��������� � ������ ������ �� UTF-8

CREATE DATABASE risk_database;

USE risk_database;

BULK INSERT AccessibilityViolations
FROM '/usr/src/app/scriptdata/acc.csv'
WITH (
	CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- ���� ������ ����� � ������ ���� ������ ���������, �������� FIRSTROW = 2
);

BULK INSERT ConfidentialityViolations
FROM '/usr/src/app/scriptdata/con.csv'
WITH (
CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- ���� ������ ����� � ������ ���� ������ ���������, �������� FIRSTROW = 2
);

BULK INSERT IntegrityViolations
FROM '/usr/src/app/scriptdata/int.csv'
WITH (
CODEPAGE = '65001',
  FIELDTERMINATOR = ';',
  ROWTERMINATOR = '\n',
  FIRSTROW = 2 -- ���� ������ ����� � ������ ���� ������ ���������, �������� FIRSTROW = 2
);