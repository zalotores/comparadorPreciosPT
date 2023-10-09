USE PRECIOS_DB

SELECT * FROM ARTICULOS
SELECT * FROM CATEGORIAS

--comando select--

SELECT A.Id, Nombre, C.Descripcion AS Categoría, Precio, S.Descripcion AS Sucursal, Observaciones, Fecha FROM ARTICULOS A, CATEGORIAS C, SUCURSALES S WHERE A.IdSucursal = S.Id AND A.IdCategoria = C.Id

--comando create--

INSERT INTO ARTICULOS (Nombre, IdCategoria, Precio, IdSucursal, Observaciones, Fecha ) VALUES ('Prueba', 1, 1.1, 1, 'esto es una prueba', '2023-10-09')

--comando update--

UPDATE ARTICULOS SET Nombre = 'prueba1', IdCategoria = 2, Precio = 2.2, IdSucursal = 2, Observaciones = 'prueba modificada', Fecha = '2020-11-13' WHERE Id = 2