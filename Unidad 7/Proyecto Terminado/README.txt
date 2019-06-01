Hola pongo aqu� un par de apuntes sobre mi API:

-Direccion de la API: "http://localhost:52734"
-Direccion del proyecto original: "http://localhost:52193"

-Ambos proyectos van separados en vez de ir en la misma soluci�n porque descubr� que se pod�an inclu�r varios proyectos en la misma soluci�n demasiado tarde.

-Cree rutas "details" para algunas de las entidades porque quer�a probar ese tipo de cosas.

-Tambi�n cree clases "DTO" orientadas simplemente a ser mostradas por la API para escoger qu� datos de cada entidad quiero mostrar, aunque supongo que
podr�a haber conseguido lo mismo con ViewModels.

-Tuve problemas con lo que creo que eran consultas circulares, por ejemplo una consola tiene una marca, y una marca tiene consolas, entonces al hacer
la consulta de una consola al principio se me romp�a el JSON lo arregl� con este par�metro en startup:

		services.AddMvc().AddJsonOptions(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });

Pero como despu�s lo que pasaba es que me sal�an las listas vac�as decid� hacer lo de los DTO antes mencionados para omitir esas propiedades en la API,
en otros casos como el de "marcas" simplemente a�ad� un [JsonIgnore] a esas propiedades.

-En el proyecto original hab�a una cosa que me hab�as dicho como simplificar sin usar el WHERE pero aquel dia no lo apunt� y se me olvid� como hacer, 
es en la vista de detalles de los controladores, si no me equivo era en:
		
		var consola = await _context.Consolas
                .Include(c => c.Marca)
                .Include(c => c.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);

            	var resultados = await _context.Consolas
                .Include(c => c.Marca)
                .Include(c => c.Tienda)
                .Where(m => m.Modelo == consola.Modelo)
                .ToListAsync();

Por mas vueltas que le di no consegu� recordar la forma en que me dijiste, y me gustar�a saberlo porque me qued� con la duda.

Un saludo, Brais.