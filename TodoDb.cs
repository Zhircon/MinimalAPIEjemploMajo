using Microsoft.EntityFrameworkCore;

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options) 
        : base(options) { } //Contructor de la base de datos

    public DbSet<Todo> Todos => Set<Todo>(); //Aqui se agregan las tablas
    // public DbSet<[Nombre_De_La_Clase_A_Almacenar]> [Nombre_De_La_Lista] => set<[Nombre_De_La_Clase_A_Almacenar];
}