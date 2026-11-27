CREATE DATABASE IF NOT EXISTS gestao_comercial_api_db;
USE gestao_comercial_api_db;

CREATE TABLE IF NOT EXISTS produtos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL DEFAULT 0,
    ativo TINYINT(1) NOT NULL DEFAULT 1
);

INSERT INTO produtos (nome, preco, estoque, ativo) 
VALUES 
('Chevrolet Onix Premier 1.0 Turbo 2026', 114990.00, 6, 1),
('Toyota Corolla Cross XRX Hybrid 2026', 206990.00, 2, 1),
('Toyota Hilux SRX Plus 2.8 4x4 2026', 319990.00, 1, 1);