USE CurrencyCalc;

CREATE TABLE CalcHistory(
                      Id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
                      Date TIMESTAMP NOT NULL,
                      Source    VARCHAR(3) NOT NULL,
                      Target VARCHAR(3) NOT NULL,
                      Value FLOAT NOT NULL,
                      Result FLOAT NOT NULL
)