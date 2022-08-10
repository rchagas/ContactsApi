using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsApi.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT IGNORE INTO LocalDB.Users (Id, Name)"
                +"VALUES (1, 'João Padeiro'), (2, 'Pedro Silva'),"
                +"(3, 'Marcelão Bolão'), (4, 'Gugu Liberato'),"
                +"(5, 'Xuxa Meneghel'), (6, 'Jô Soares'), (7, 'Silvio Santos'),"
                +"(8, 'Roberto Marinho'), (9, 'Hebe Camargo'), (10, 'Ivete Sangalo');"
            );

            migrationBuilder.Sql(
                "INSERT IGNORE INTO LocalDB.Contacts (Id, `Type`, Value, UserId)"
                +"VALUES (1,  0, '(31)90101-0101', 1),  (2,  1, 'joao@gmail.com',     1),  (3,  2, '(31)9101-0101', 1),"
                +       "(4,  0, '(31)90201-0102', 2),  (5,  1, 'pedro@gemail.com',   2),  (6,  2, '(31)9202-0202', 2),"
                +       "(7,  0, '(31)90301-0103', 3),  (8,  1, 'marcelo@gemail.com', 3),  (9,  2, '(31)9303-0303', 3),"
                +       "(10, 0, '(31)90401-0104', 4),  (11, 1, 'gugu@gemail.com',    4),  (12, 2, '(31)9404-0404', 4),"
                +       "(13, 0, '(31)90501-0105', 5),  (14, 1, 'xuxa@gemail.com',    5),  (15, 2, '(31)9505-0505', 5),"
                +       "(16, 0, '(31)90601-0106', 6),  (17, 1, 'jo@gemail.com',      6),  (18, 2, '(31)9606-0606', 6),"
                +       "(19, 0, '(31)90701-0107', 7),  (20, 1, 'silvio@gemail.com',  7),  (21, 2, '(31)9707-0107', 7),"
                +       "(22, 0, '(31)90801-0108', 8),  (23, 1, 'roberto@gemail.com', 8),  (24, 2, '(31)9808-0808', 8),"
                +       "(25, 0, '(31)90901-0109', 9),  (26, 1, 'hebe@gemail.com',    9),  (27, 2, '(31)9909-0909', 9),"
                +       "(28, 0, '(31)9101-01010', 10), (29, 1, 'ivete@gemail.com',   10), (30, 2, '(31)9101-1010', 10);"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DELETE from LocalDB.Contacts"
            ); 
            migrationBuilder.Sql(
                "DELETE from LocalDB.Users"
            );   
        }
    }
}
