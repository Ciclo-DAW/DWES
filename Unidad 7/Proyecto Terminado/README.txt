Hola pongo aquí un par de apuntes sobre mi API:

-Direccion de la API: "http://localhost:52734"
-Direccion del proyecto original: "http://localhost:52193"

-Ambos proyectos van separados en vez de ir en la misma solución porque descubrí que se podían incluír varios proyectos en la misma solución demasiado tarde.

-Cree rutas "details" para algunas de las entidades porque quería probar ese tipo de cosas.

-También cree clases "DTO" orientadas simplemente a ser mostradas por la API para escoger qué datos de cada entidad quiero mostrar, aunque supongo que
podría haber conseguido lo mismo con ViewModels.

-Tuve problemas con lo que creo que eran consultas circulares, por ejemplo una consola tiene una marca, y una marca tiene consolas, entonces al hacer
la consulta de una consola al principio se me rompía el JSON lo arreglé con este parámetro en startup:

		services.AddMvc().AddJsonOptions(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });

Pero como después lo que pasaba es que me salían las listas vacías decidí hacer lo de los DTO antes mencionados para omitir esas propiedades en la API,
en otros casos como el de "marcas" simplemente añadí un [JsonIgnore] a esas propiedades.

-En el proyecto original había una cosa que me habías dicho como simplificar sin usar el WHERE pero aquel dia no lo apunté y se me olvidó como hacer, 
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

Por mas vueltas que le di no conseguí recordar la forma en que me dijiste, y me gustaría saberlo porque me quedé con la duda.

Un saludo, Brais.