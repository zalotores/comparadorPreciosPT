USE PRECIOS_DB

SELECT * FROM ARTICULOS

--comando select--

SELECT A.Id, Nombre, C.Descripcion AS Categoría, Precio, S.Descripcion AS Sucursal, Observaciones, Fecha FROM ARTICULOS A, CATEGORIAS C, SUCURSALES S WHERE A.IdSucursal = S.Id AND A.IdCategoria = C.Id

