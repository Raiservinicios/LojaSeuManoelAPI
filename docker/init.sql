CREATE DATABASE LojaSeuManoel;
GO
USE LojaSeuManoel;
GO

CREATE TABLE Caixas (
    CaixaId NVARCHAR(50) PRIMARY KEY,
    Altura INT NOT NULL,
    Largura INT NOT NULL,
    Comprimento INT NOT NULL
);

INSERT INTO Caixas (CaixaId, Altura, Largura, Comprimento) VALUES
('Caixa 1', 30, 40, 80),
('Caixa 2', 80, 50, 40),
('Caixa 3', 50, 80, 60);

