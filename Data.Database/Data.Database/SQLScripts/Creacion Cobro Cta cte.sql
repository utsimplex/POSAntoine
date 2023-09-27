CREATE TABLE CobrosCuentaCorriente (
    id INT PRIMARY KEY IDENTITY(1,1),
    NumeroDocumentoCliente NVARCHAR(255),
    FacturasAfectadas NVARCHAR(255),
    FechaHora DATETIME,
    MedioDePago NVARCHAR(255),
    MontoRecibido DECIMAL(18, 2)
);
