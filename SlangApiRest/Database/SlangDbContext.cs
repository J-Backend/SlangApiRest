using Microsoft.EntityFrameworkCore;
using SlangApiRest.ModelsDB;

namespace SlangApiRest.Database
{
    public class SlangDbContext : DbContext
    {
        public SlangDbContext(DbContextOptions<SlangDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 

            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 1,
                Phrase = "That'll be the day",
                Meaning = "Cuando las vacas vuelen"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 2,
                Phrase = "Enough is enough",
                Meaning = "Ya basta"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 3,
                Phrase = "Get you mind off",
                Meaning = "Dejar de pensar en ..."
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 4,
                Phrase = "I hate your guts",
                Meaning = "Te odio"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 5,
                Phrase = "On edge",
                Meaning = "Muy nervioso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 6,
                Phrase = "Not have the guts",
                Meaning = "No tener el coraje de hacer algo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 7,
                Phrase = "Inside joke",
                Meaning = "Broma interna de un grupo específico"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 8,
                Phrase = "Old school",
                Meaning = "De la vieja escuela"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 9,
                Phrase = "Show up",
                Meaning = "Aparecer"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 10,
                Phrase = "Flex",
                Meaning = "Presumir"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 11,
                Phrase = "Yo",
                Meaning = "Oye"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 12,
                Phrase = "Make out",
                Meaning = "Besar"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 13,
                Phrase = "Bod",
                Meaning = "Cuerpo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 14,
                Phrase = "Hottie",
                Meaning = "Bombón"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 15,
                Phrase = "I'm done with it",
                Meaning = "Ya me cansé, Ya lo he dejado"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 16,
                Phrase = "Woke Aware",
                Meaning = "Informado / Al tanto"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 17,
                Phrase = "Antsy",
                Meaning = "Ansioso / Nervioso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 18,
                Phrase = "I'm outta here",
                Meaning = "Me voy de aquí"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 19,
                Phrase = "Brew",
                Meaning = "Cerveza"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 20,
                Phrase = "Rookie",
                Meaning = "Novato / Principiante"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 21,
                Phrase = "Shindig",
                Meaning = "Fiesta / Festejo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 22,
                Phrase = "Swell",
                Meaning = "Genial / Grandioso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 23,
                Phrase = "Cut a deal",
                Meaning = "Hacer un trato / Cerrar un trato"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 24,
                Phrase = "Homey",
                Meaning = "Amigo / Camarada"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 25,
                Phrase = "Cut and dry",
                Meaning = "Claro y simple"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 26,
                Phrase = "Passed out",
                Meaning = "Inconsciente"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 27,
                Phrase = "Epic",
                Meaning = "Épico / Impresionante / Increíble"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 28,
                Phrase = "Whiz",
                Meaning = "Inteligente / Genio"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 29,
                Phrase = "Gig",
                Meaning = "Trabajo / Chamba"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 30,
                Phrase = "Chick",
                Meaning = "Chica / Jóven"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 31,
                Phrase = "Nuts",
                Meaning = "Loco / Locura"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 32,
                Phrase = "Wack",
                Meaning = "Malo / Loco"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 33,
                Phrase = "Basic",
                Meaning = "Simple / Aburrido"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 34,
                Phrase = "Joint",
                Meaning = "Antro / Bar baráto"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 35,
                Phrase = "Goof",
                Meaning = "Tonto / Tontería / Payaso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 36,
                Phrase = "Freeway",
                Meaning = "Autopista"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 37,
                Phrase = "Recap",
                Meaning = "Resumir / Recapitular"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 38,
                Phrase = "I'm Amped",
                Meaning = "Estoy Emocionado"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 39,
                Phrase = "Vacay",
                Meaning = "Vacaciones"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 40,
                Phrase = "She is a Looker",
                Meaning = "Ella es guapa"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 41,
                Phrase = "Upscale",
                Meaning = "Exclusivo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 42,
                Phrase = "Beemer",
                Meaning = "Auto BMW"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 43,
                Phrase = "Dough",
                Meaning = "Dinero"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 44,
                Phrase = "Wallflower",
                Meaning = "Tímido / Introvertido"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 45,
                Phrase = "Geek",
                Meaning = "Nerd / Cerebrito"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 46,
                Phrase = "Cray",
                Meaning = "Loco"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 47,
                Phrase = "Racket",
                Meaning = "Alboroto / Ruido molesto / Barullo / Escándalo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 48,
                Phrase = "Riot",
                Meaning = "Alguien muy gracioso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 49,
                Phrase = "Vibes",
                Meaning = "Vibras"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 50,
                Phrase = "Y'all",
                Meaning = "Todos ustedes"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 51,
                Phrase = "Hella",
                Meaning = "Muy"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 52,
                Phrase = "Folks",
                Meaning = "Padres / Muchachos / Gente"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 53,
                Phrase = "Later",
                Meaning = "Hasta luego"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 54,
                Phrase = "Weirdo",
                Meaning = "Alguien raro"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 55,
                Phrase = "Munchies",
                Meaning = "Bocadillos / Antojos"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 56,
                Phrase = "Veggies",
                Meaning = "Verduras"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 57,
                Phrase = "Drama queen",
                Meaning = "Melodramático / Exagerado"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 58,
                Phrase = "Oh my godness / Oh my god",
                Meaning = "Oh dios mío"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 59,
                Phrase = "Tag along",
                Meaning = "Acompañar / colarse"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 60,
                Phrase = "Short on cash",
                Meaning = "No tener mucho dinero / Sin plata"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 61,
                Phrase = "Crank it up",
                Meaning = "Súbelo fuerte y rápido"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 62,
                Phrase = "In the works",
                Meaning = "En curso / En proceso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 63,
                Phrase = "A class act",
                Meaning = "Una persona destacada / Una maravilla"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 64,
                Phrase = "Bummed",
                Meaning = "Fastidiado / Disgustado / Decepcionado / Molesto"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 65,
                Phrase = "Freak out",
                Meaning = "Ponerse loco"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 66,
                Phrase = "Shady",
                Meaning = "Sospechoso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 67,
                Phrase = "Lame",
                Meaning = "Patético / Lamentable"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 68,
                Phrase = "Mellow",
                Meaning = "Relajado / Despreocupado / Muy tranquilo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 69,
                Phrase = "Clear out",
                Meaning = "Desocupar / Irse"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 70,
                Phrase = "Cool off",
                Meaning = "Refrescarse / Tranquilizarse"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 71,
                Phrase = "Cutie pie",
                Meaning = "Tesorito / Lindura"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 72,
                Phrase = "A blast",
                Meaning = "Una maravilla"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 73,
                Phrase = "Take a load off",
                Meaning = "Tomarse un descanso / Relajarse"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 74,
                Phrase = "Keep it real",
                Meaning = "Sé tu mismo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 75,
                Phrase = "Fess up",
                Meaning = "Confesar / Admitir"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 76,
                Phrase = "Drink up",
                Meaning = "Acaba el trago"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 77,
                Phrase = "What's good?",
                Meaning = "¿Qué hay de bueno?"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 78,
                Phrase = "Bounce",
                Meaning = "Salir"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 79,
                Phrase = "Slouch",
                Meaning = "Perezoso"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 80,
                Phrase = "Nosy",
                Meaning = "Entrometido / Curioso / Chepito / Sapo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 81,
                Phrase = "Decent",
                Meaning = "Tener un nivel decente en algo"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 82,
                Phrase = "A drag",
                Meaning = "Un fastidio / Desagrado / Aburrido"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 83,
                Phrase = "Hassle",
                Meaning = "Molestia"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 84,
                Phrase = "Quitter",
                Meaning = "Cobarde / Desertor"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 85,
                Phrase = "Take off",
                Meaning = "Irse / Despegar"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 86,
                Phrase = "A good sport",
                Meaning = "Un buen jugador / Alguien con buena actitud"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 87,
                Phrase = "Sleep over",
                Meaning = "Pasar la noche / Quedarse a dormir"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 88,
                Phrase = "Out like a light",
                Meaning = "Quedarse dormido / Dormirse rápido"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 89,
                Phrase = "Hell of a guy",
                Meaning = "Un gran chico / Muy bueno / Muy impresionante"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 90,
                Phrase = "Leave me hanging",
                Meaning = "Dejarme esperando"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 91,
                Phrase = "Vibe",
                Meaning = "Onda / Vibra / Energía"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 92,
                Phrase = "Way to go",
                Meaning = "Así se hace / Bien hecho"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 93,
                Phrase = "I'm beat",
                Meaning = "Estoy cansadísimo / Estoy exhausto / No puedo más"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 94,
                Phrase = "Pissed off",
                Meaning = "Enfadado / Muy Enojado"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 95,
                Phrase = "Hold on",
                Meaning = "Esperar"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 96,
                Phrase = "Cool it",
                Meaning = "Tranquilizarse / Calmarse"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 97,
                Phrase = "Cheers",
                Meaning = "Salud / Brindis"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 98,
                Phrase = "Tie the knot",
                Meaning = "Casarse"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 99,
                Phrase = "It's on me",
                Meaning = "Yo invito"
            });
            modelBuilder.Entity<Slang>().HasData(new Slang
            {
                Id = 100,
                Phrase = "Chill out",
                Meaning = "Relajarse"
            });
        }

        public DbSet<Slang> Slangs { get; set; }
    }
}
