USE PRECIOS_DB

SELECT * FROM ARTICULOS

--comando select--

SELECT A.Id, Nombre, C.Descripcion AS Categor�a, Precio, S.Descripcion AS Sucursal, Observaciones, Fecha FROM ARTICULOS A, CATEGORIAS C, SUCURSALES S WHERE A.IdSucursal = S.Id AND A.IdCategoria = C.Id

