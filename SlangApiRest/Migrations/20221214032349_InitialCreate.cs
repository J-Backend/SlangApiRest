using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SlangApiRest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phrase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meaning = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slangs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Slangs",
                columns: new[] { "Id", "Meaning", "Phrase" },
                values: new object[,]
                {
                    { 1, "Cuando las vacas vuelen", "That'll be the day" },
                    { 2, "Ya basta", "Enough is enough" },
                    { 3, "Dejar de pensar en ...", "Get you mind off" },
                    { 4, "Te odio", "I hate your guts" },
                    { 5, "Muy nervioso", "On edge" },
                    { 6, "No tener el coraje de hacer algo", "Not have the guts" },
                    { 7, "Broma interna de un grupo específico", "Inside joke" },
                    { 8, "De la vieja escuela", "Old school" },
                    { 9, "Aparecer", "Show up" },
                    { 10, "Presumir", "Flex" },
                    { 11, "Oye", "Yo" },
                    { 12, "Besar", "Make out" },
                    { 13, "Cuerpo", "Bod" },
                    { 14, "Bombón", "Hottie" },
                    { 15, "Ya me cansé / Ya lo he dejado", "I'm done with it" },
                    { 16, "Informado / Al tanto", "Woke / Aware" },
                    { 17, "Ansioso / Nervioso", "Antsy" },
                    { 18, "Me voy de aquí", "I'm outta here" },
                    { 19, "Cerveza", "Brew" },
                    { 20, "Novato / Principiante", "Rookie" },
                    { 21, "Fiesta / Festejo", "Shindig" },
                    { 22, "Genial / Grandioso", "Swell" },
                    { 23, "Hacer un trato / Cerrar un trato", "Cut a deal" },
                    { 24, "Amigo / Camarada", "Homey" },
                    { 25, "Claro y simple", "Cut and dry" },
                    { 26, "Inconsciente", "Passed out" },
                    { 27, "Épico / Impresionante / Increíble", "Epic" },
                    { 28, "Inteligente / Genio", "Whiz" },
                    { 29, "Trabajo / Chamba", "Gig" },
                    { 30, "Chica / Jóven", "Chick" },
                    { 31, "Loco / Locura", "Nuts" },
                    { 32, "Malo / Loco", "Wack" },
                    { 33, "Simple / Aburrido", "Basic" },
                    { 34, "Antro / Bar baráto", "Joint" },
                    { 35, "Tonto / Tontería / Payaso", "Goof" },
                    { 36, "Autopista", "Freeway" },
                    { 37, "Resumir / Recapitular", "Recap" },
                    { 38, "Estoy Emocionado", "I'm Amped" },
                    { 39, "Vacaciones", "Vacay" },
                    { 40, "Ella es guapa", "She is a Looker" },
                    { 41, "Exclusivo", "Upscale" },
                    { 42, "Auto BMW", "Beemer" },
                    { 43, "Dinero", "Dough" },
                    { 44, "Tímido / Introvertido", "Wallflower" },
                    { 45, "Nerd / Cerebrito", "Geek" },
                    { 46, "Loco", "Cray" },
                    { 47, "Alboroto / Ruido molesto / Barullo / Escándalo", "Racket" },
                    { 48, "Alguien muy gracioso", "Riot" },
                    { 49, "Vibras", "Vibes" },
                    { 50, "Todos ustedes", "Y'all" },
                    { 51, "Muy", "Hella" },
                    { 52, "Padres / Muchachos / Gente", "Folks" },
                    { 53, "Hasta luego", "Later" },
                    { 54, "Alguien raro", "Weirdo" },
                    { 55, "Bocadillos / Antojos", "Munchies" },
                    { 56, "Verduras", "Veggies" },
                    { 57, "Melodramático / Exagerado", "Drama queen" },
                    { 58, "Oh dios mío", "Oh my godness / Oh my god" },
                    { 59, "Acompañar / colarse", "Tag along" },
                    { 60, "No tener mucho dinero / Sin plata", "Short on cash" },
                    { 61, "Súbelo fuerte y rápido", "Crank it up" },
                    { 62, "En curso / En proceso", "In the works" },
                    { 63, "Una persona destacada / Una maravilla", "A class act" },
                    { 64, "Fastidiado / Disgustado / Decepcionado / Molesto", "Bummed" },
                    { 65, "Ponerse loco", "Freak out" },
                    { 66, "Sospechoso", "Shady" },
                    { 67, "Patético / Lamentable", "Lame" },
                    { 68, "Relajado / Despreocupado / Muy tranquilo", "Mellow" },
                    { 69, "Desocupar / Irse", "Clear out" },
                    { 70, "Refrescarse / Tranquilizarse", "Cool off" },
                    { 71, "Tesorito / Lindura", "Cutie pie" },
                    { 72, "Una maravilla", "A blast" },
                    { 73, "Tomarse un descanso / Relajarse", "Take a load off" },
                    { 74, "Sé tu mismo", "Keep it real" },
                    { 75, "Confesar / Admitir", "Fess up" },
                    { 76, "Acaba el trago", "Drink up" },
                    { 77, "¿Qué hay de bueno?", "What's good?" },
                    { 78, "Salir", "Bounce" },
                    { 79, "Perezoso", "Slouch" },
                    { 80, "Entrometido / Curioso / Chepito / Sapo", "Nosy" },
                    { 81, "Tener un nivel decente en algo", "Decent" },
                    { 82, "Un fastidio / Desagrado / Aburrido", "A drag" },
                    { 83, "Molestia", "Hassle" },
                    { 84, "Cobarde / Desertor", "Quitter" },
                    { 85, "Irse / Despegar", "Take off" },
                    { 86, "Un buen jugador / Alguien con buena actitud", "A good sport" },
                    { 87, "Pasar la noche / Quedarse a dormir", "Sleep over" },
                    { 88, "Quedarse dormido / Dormirse rápido", "Out like a light" },
                    { 89, "Un gran chico / Muy bueno / Muy impresionante", "Hell of a guy" },
                    { 90, "Dejarme esperando", "Leave me hanging" },
                    { 91, "Onda / Vibra / Energía", "Vibe" },
                    { 92, "Así se hace / Bien hecho", "Way to go" },
                    { 93, "Estoy cansadísimo / Estoy exhausto / No puedo más", "I'm beat" },
                    { 94, "Enfadado / Muy Enojado", "Pissed off" },
                    { 95, "Esperar", "Hold on" },
                    { 96, "Tranquilizarse / Calmarse", "Cool it" },
                    { 97, "Salud / Brindis", "Cheers" },
                    { 98, "Casarse", "Tie the knot" },
                    { 99, "Yo invito", "It's on me" },
                    { 100, "Relajarse", "Chill out" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slangs");
        }
    }
}
