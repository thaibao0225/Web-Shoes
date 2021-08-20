using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Shoes.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactSystems",
                columns: table => new
                {
                    Contact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cu_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pd_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Price = table.Column<int>(type: "int", nullable: false),
                    pd_ReducePrice = table.Column<int>(type: "int", nullable: false),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Rate = table.Column<int>(type: "int", nullable: false),
                    pd_MenuFacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Technologies = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInRoleModel",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRoleModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInCategories",
                columns: table => new
                {
                    pic_CategoriesId = table.Column<int>(type: "int", nullable: false),
                    pic_productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInCategories", x => new { x.pic_productId, x.pic_CategoriesId });
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Categories_pic_CategoriesId",
                        column: x => x.pic_CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Products_pic_productId",
                        column: x => x.pic_productId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bill_Paid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cart_UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_cart_UserID",
                        column: x => x.cart_UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    review_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_review_UserId",
                        column: x => x.review_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    wl_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wl_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.wl_Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Users_wl_UserId",
                        column: x => x.wl_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_CartId = table.Column<int>(type: "int", nullable: false),
                    pic_ProductId = table.Column<int>(type: "int", nullable: false),
                    pic_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => new { x.pic_CartId, x.pic_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCart_Carts_pic_CartId",
                        column: x => x.pic_CartId,
                        principalTable: "Carts",
                        principalColumn: "cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Products_pic_ProductId",
                        column: x => x.pic_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewInproduct",
                columns: table => new
                {
                    rip_ReviewId = table.Column<int>(type: "int", nullable: false),
                    rip_ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewInproduct", x => new { x.rip_ProductId, x.rip_ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Products_rip_ProductId",
                        column: x => x.rip_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Reviews_rip_ReviewId",
                        column: x => x.rip_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInWishlist",
                columns: table => new
                {
                    piw_WishlistId = table.Column<int>(type: "int", nullable: false),
                    piw_ProductId = table.Column<int>(type: "int", nullable: false),
                    piw_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInWishlist", x => new { x.piw_WishlistId, x.piw_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Products_piw_ProductId",
                        column: x => x.piw_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Wishlists_piw_WishlistId",
                        column: x => x.piw_WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "wl_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_Description", "about_Img" },
                values: new object[] { 1, "string", "string" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { 1, "women", "", "" },
                    { 2, "Man", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Email", "Contact_Phone", "Contact_Website" },
                values: new object[] { 1, "HCM", "admin@gmail.com", "0123456789", "https://shoes.com" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { 1, "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Brand", "pd_Color", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Material", "pd_MenuFacturer", "pd_Name", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size", "pd_Style", "pd_Technologies" },
                values: new object[,]
                {
                    { 13, "Nike", "Beach/Topaz Gold/Bright Crimson/Black", "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "https://drive.google.com/uc?export=download&id=1tSgTxHUCeZU591E9hQI4Ax22NiD9wspM", "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh", "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf", "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya", "3", "3", "Nike SB Nyjah Free 2", 10000, 4, 500, "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "BV2078-200", "3" },
                    { 12, "Nike", "Ghost/Ashen Slate/Obsidian Mist/Obsidian", "We could use a lot of superlatives to describe the Nike Air Max 2021.We could tell you that we've incorporated recycled materials to design a sneaker with at least 20% recycled content.Or that the new Air cushioning unit underfoot is our most revolutionary.Perhaps we'd call it the the pinnacle of comfort waxing poetic about the cored-out foam midsole that gives you the lightest, softest feel.But maybe we just say it's modern meets technical with a splash of heritage DNA.What fun is there in giving away the surprises?", "https://drive.google.com/uc?export=download&id=1IfOLISEQfFw1xol1gIopWvnLjcPxIhvx", "https://drive.google.com/uc?export=download&id=184n1JhhW9eVPiPU01g2LsrQaga75xZoT", "https://drive.google.com/uc?export=download&id=1vQa7rOZejxU29875pv8ne4fyrxt8WEdH", "https://drive.google.com/uc?export=download&id=1shZnWARtq5SwsibFewT6Km0duAMAkpoZ", "3", "3", "Nike Air Max 2021", 10000, 4, 500, "We could use a lot of superlatives to describe the Nike Air Max 2021.We could tell you that we've incorporated recycled materials to design a sneaker with at least 20% recycled content.Or that the new Air cushioning unit underfoot is our most revolutionary.Perhaps we'd call it the the pinnacle of comfort; waxing poetic about the cored-out foam midsole that gives you the lightest, softest feel.But maybe we just say it's modern meets technical with a splash of heritage DNA.What fun is there in giving away the surprises?", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DA1925-002", "3" },
                    { 11, "Nike", "Black/Wolf Grey/Cool Grey/White", "Inspired by the community art spaces of Barcelona, the Nike SB Zoom Blazer Mid Premium is made from a collage of materials like suede, leather and canvas.The design is elevated with a multi-coloured Nike embroidery on the heel and a mismatched Swoosh, capped off by a contrasting herringbone sole.", "https://drive.google.com/uc?export=download&id=1Ij5hmx63q8idVVTLu7nKiv0OJsqOdor6", "https://drive.google.com/uc?export=download&id=1EERkVDnTn-m3dfv2eUCxIGIKZuENwZIu", "https://drive.google.com/uc?export=download&id=1B6Ae6KBW8vwsPz9K1btBZuSC9OZPn5Hu", "https://drive.google.com/uc?export=download&id=1WS6keGw5BUnYs04Ji-yuVf8_CFdh-mRz", "3", "3", "Nike SB Zoom Blazer Mid Premium", 10000, 4, 500, "Inspired by the community art spaces of Barcelona, the Nike SB Zoom Blazer Mid Premium is made from a collage of materials like suede, leather and canvas.The design is elevated with a multi-coloured Nike embroidery on the heel and a mismatched Swoosh, capped off by a contrasting herringbone sole.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DA8854-001", "3" },
                    { 10, "Nike", "Light Mulberry/Flash Crimson", "Fast, rugged and just as at home in the city as it is in deserts, canyons and mountains, the Nike ACG Mountain Fly Low is ready for whatever you throw at it.The lightweight Ripstop and synthetic upper is durable and airy, while the easy-to-cinch lacing system adds on-the-go personalisation.The sticky rubber outsole brings crag-inspired traction as the soft Nike React foam sole delivers undisputed comfort whether you're pounding the pavement in the city wilds or leaping rock to rock in Joshua Tree.", "https://drive.google.com/uc?export=download&id=1l9m448SGsvJOMrAK4TRpAMTgptxq2yFN", "https://drive.google.com/uc?export=download&id=1nm4RlNHYo8JP3KtJvT_bvFqOQ5vEGY2m", "https://drive.google.com/uc?export=download&id=1DcJqtgAnjTxw_zZyvTEsktIcR5pljTk6", "https://drive.google.com/uc?export=download&id=1bjUxZvzpqdlFxn5GrukZilFWpwx5UyvX", "3", "3", "Nike ACG Mountain Fly Low", 10000, 4, 500, "Fast, rugged and just as at home in the city as it is in deserts, canyons and mountains, the Nike ACG Mountain Fly Low is ready for whatever you throw at it.The lightweight Ripstop and synthetic upper is durable and airy, while the easy-to-cinch lacing system adds on-the-go personalisation.The sticky rubber outsole brings crag-inspired traction as the soft Nike React foam sole delivers undisputed comfort whether you're pounding the pavement in the city wilds or leaping rock to rock in Joshua Tree.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DC9045-500", "3" },
                    { 9, "Nike", "Grey Fog/Melon Tint/Metallic Silver", "Take on the tough terrain of the outdoors.The Nike ACG Air Nasu 2 steps up the durability with Ripstop on the upper and reinforced details to stand up to the rigours of the trail.It has mesh elements up top and a lining within to help keep you on your path with a breathable, supportive feel.A sticky rubber outsole is highlighted with lugs that are designed to help give you traction when navigating wet and rocky surfaces.", "https://drive.google.com/uc?export=download&id=1-dFkb3D0lzmlOTVMeqxEZaWAbQDWIjhF", "https://drive.google.com/uc?export=download&id=1kRRsPNYRT0V5f7LKVRmJp82QMWJVYxeQ", "https://drive.google.com/uc?export=download&id=15wsxpi791SMVlR2Cn7k6FAbCOgUt3I2U", "https://drive.google.com/uc?export=download&id=1XdL62dPC4dpqNdc-BhHnrkm2Hl6morgo", "3", "3", "Nike ACG Air Nasu 2", 10000, 4, 500, "Take on the tough terrain of the outdoors.The Nike ACG Air Nasu 2 steps up the durability with Ripstop on the upper and reinforced details to stand up to the rigours of the trail.It has mesh elements up top and a lining within to help keep you on your path with a breathable, supportive feel.A sticky rubber outsole is highlighted with lugs that are designed to help give you traction when navigating wet and rocky surfaces.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DC8296-001", "3" },
                    { 8, "Nike", "Metallic Silver/Black/White/Persian Violet", "Inspired by Japanese bullet trains, the Nike Air Max 97 lets you push your style full speed ahead.Taking the revolutionary full-length Nike Air unit that shook up the running world and adding the original silver bullet colours, it lets you ride in first-class comfort.", "https://drive.google.com/uc?export=download&id=1AblOdiYwK5ys32KY23IKPSCeAi6KWnsX", "https://drive.google.com/uc?export=download&id=1-zJ4GbHm0iys-PO3XwWHTOB1LLlMQhaR", "https://drive.google.com/uc?export=download&id=1UUI3tV4jyTpPvv8akrL0jcJXDuIWzjM1", "https://drive.google.com/uc?export=download&id=1AXIRrKM96HazbtzcSxhKY59wFjEm1zVe", "3", "3", "Nike Air Max 97", 10000, 4, 500, "Inspired by Japanese bullet trains, the Nike Air Max 97 lets you push your style full speed ahead.Taking the revolutionary full-length Nike Air unit that shook up the running world and adding the original silver bullet colours, it lets you ride in first-class comfort.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DJ0717-001", "3" },
                    { 7, "Nike", "Hasta/Thunder Blue/Bucktan/Obsidian", "Made from at least 20% recycled content by weight, the Nike Air Max 97 SE takes a fresh step towards the future of footwear.The upper features 100% recycled canvas and accents of cork.The embroidered cork graphic on the tongue nods to the plant used in the shoe.", "https://drive.google.com/uc?export=download&id=13rEVfOXI6Sj9J41Z45Cti6pRinyewQ6n", "https://drive.google.com/uc?export=download&id=1cITDpeROBtZfWCsBYRj-obyMYR4SZQYX", "https://drive.google.com/uc?export=download&id=1Suli5ByGxovAPGmd_kM6GIenMTy32JPe", "https://drive.google.com/uc?export=download&id=1SkQjussYGb4HIrIIk0URRFY-L0rZjEpI", "3", "3", "Nike Air Max 97 SE", 10000, 4, 500, "Made from at least 20% recycled content by weight, the Nike Air Max 97 SE takes a fresh step towards the future of footwear.The upper features 100% recycled canvas and accents of cork.The embroidered cork graphic on the tongue nods to the plant used in the shoe.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DC3986-300", "3" },
                    { 6, "Nike", "Moon Fossil/Black", "From city hikes to canyon trails and long walks on the beach, the Nike ACG Air Deschutz + is built to feel comfortable.It's got a classic '90s look and rugged outdoor-inspired design, with plush padding around the ankle for support.A heavy-duty webbing strap and adjustable hook-and-loop closure keep you focused on the journey ahead.", "https://drive.google.com/uc?export=download&id=1IAWjF3G2Lwnwj7sID83qZAnQqdfzjxkk", "https://drive.google.com/uc?export=download&id=1ezOB26pX2VmYZC1uVja89pZ4QJty7hXe", "https://drive.google.com/uc?export=download&id=1IiK2AM0M9bKRhSBofRlNSR8ZhseQsUmG", "https://drive.google.com/uc?export=download&id=1rctQk2u8mHcN41-GdWdCfHSeSRvDr1dr", "3", "3", "Nike ACG Air Deschutz +", 10000, 4, 500, "From city hikes to canyon trails and long walks on the beach, the Nike ACG Air Deschutz + is built to feel comfortable.It's got a classic '90s look and rugged outdoor-inspired design, with plush padding around the ankle for support.A heavy-duty webbing strap and adjustable hook-and-loop closure keep you focused on the journey ahead.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DC9092-001", "3" },
                    { 3, "Nike", "Cream II/Orange/Black/White", "Bringing the classic BRS athletics style into a modern realm with at least 20% recycled materials by weight, the Nike Waffle One Crater is eye-candy for your feet.The playful speckled look on the midsole is created from Crater Foam, a cushiony material made from Nike Grind rubber and Nike foam materials.And for added depth, the sport-inspired upper includes transparent mesh made from recycled polyester.", "https://drive.google.com/uc?export=download&id=1sBANC4Og5eumFJBTVLYGIp2qTBKfwSzh", "https://drive.google.com/uc?export=download&id=1kFLigFwBNPiqYhIOs2QRL39nRo0IJYWS", "https://drive.google.com/uc?export=download&id=1KZJQR5jt9rzVOBxfUZRx-tjKoO3dKNDJ", "https://drive.google.com/uc?export=download&id=10oXph87Rn43M13WNaxJWpL0XS_Mf_JFt", "3", "3", "Nike Waffle One Crater", 10000, 4, 500, "Bringing the classic BRS athletics style into a modern realm with at least 20% recycled materials by weight, the Nike Waffle One Crater is eye-candy for your feet.The playful speckled look on the midsole is created from Crater Foam, a cushiony material made from Nike Grind rubber and Nike foam materials.And for added depth, the sport-inspired upper includes transparent mesh made from recycled polyester.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DC2650-200", "3" },
                    { 4, "Nike", "Hemp/Sand Drift/Light Orewood Brown/Summit White", "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 Premium stays true to its roots, with the iconic Waffle outsole, stitched overlays and classic TPU accents. Fresh colours give a modern look while Max Air cushioning adds comfort to your journey.", "https://drive.google.com/uc?export=download&id=1A74yTUs0Lmya24nL5UPG8N6cV7GFhn5a", "https://drive.google.com/uc?export=download&id=1K85ItvCTycDSRX9p1Jbzm7Egg5l6OdRa", "https://drive.google.com/uc?export=download&id=1b5FDJjrsLKAlj7zBVGLoxdp_gaVTFkVE", "https://drive.google.com/uc?export=download&id=1LSQUzknGNiwOIVtHFNmPhGSh8ZE0CFJx", "3", "3", "Nike Air Max 90 Premium", 10000, 4, 500, "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 Premium stays true to its roots, with the iconic Waffle outsole, stitched overlays and classic TPU accents. Fresh colours give a modern look while Max Air cushioning adds comfort to your journey.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DA1641-201", "3" },
                    { 14, "Nike", "Beach/Topaz Gold/Bright Crimson/Black", "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "https://drive.google.com/uc?export=download&id=1tSgTxHUCeZU591E9hQI4Ax22NiD9wspM", "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh", "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf", "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya", "3", "3", "Nike SB Nyjah Free 2", 10000, 4, 500, "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "BV2078-200", "3" },
                    { 2, "Nike", "Medium Olive/Carbon Green/Sail/Black", "The radiance lives on in the Nike Air Force 1 GORE-TEX, the b-ball OG that puts a fresh spin on what you know best: crisp leather, bold colours and the perfect amount of flash to make you shine.This time it's clad in GORE-TEX technology.", "https://drive.google.com/uc?export=download&id=1YBpU6fwcCzV18ho__mhCCO0yD8ES-ef7", "https://drive.google.com/uc?export=download&id=1Y4gS9zvfZdshJc4YySjz13ZGlMIft4kv", "https://drive.google.com/uc?export=download&id=1AyILI7QsTzqBPE6OvDMZpY7OAtxjkuH8", "https://drive.google.com/uc?export=download&id=1WT_vD4nC_szHPH9LVbl_UztqvXlmqs2e", "2", "2", "Nike Air Force 1", 10000, 5, 500, "The radiance lives on in the Nike Air Force 1 GORE-TEX, the b-ball OG that puts a fresh spin on what you know best: crisp leather, bold colours and the perfect amount of flash to make you shine.This time it's clad in GORE-TEX technology.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DM6435-222", "2" },
                    { 1, "Nike", "White/White", "The radiance lives on in the Nike Air Force 1 '07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.", "https://drive.google.com/uc?export=download&id=1xnPOpwwf0C13abtd60BwBAqU-7eCSJFD", "https://drive.google.com/uc?export=download&id=1YBpU6fwcCzV18ho__mhCCO0yD8ES-ef7", "https://drive.google.com/uc?export=download&id=1sBANC4Og5eumFJBTVLYGIp2qTBKfwSzh", "https://drive.google.com/uc?export=download&id=1A74yTUs0Lmya24nL5UPG8N6cV7GFhn5a", "1", "1", "Nike Air Force 1 07", 10000, 5, 500, "The radiance lives on in the Nike Air Force 1 '07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "CW2288-111", "1" },
                    { 5, "Nike", "Dark Driftwood/Sail/Light Chocolate/Black", "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 stays true to its roots with the iconic Waffle sole, stitched overlays and classic TPU accents on the heel and eyestays.A variety of materials on the upper gives a modern look, while Max Air cushioning adds comfort to your journey.", "https://drive.google.com/uc?export=download&id=17puCPm8dDBi_11T0ei5JznoGXugbuPi8", "https://drive.google.com/uc?export=download&id=1kxFSmfxV3eYg_2ikz2fF0G4UoXPedRJG", "https://drive.google.com/uc?export=download&id=1DxgC1AAKFgDxKSOtBnp_kytP3TlZ-kqr", "https://drive.google.com/uc?export=download&id=1dmp8HCRjPGXUyT3TkkHLZNiP9utabt_S", "3", "3", "Nike Air Max 90", 10000, 4, 500, "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 stays true to its roots with the iconic Waffle sole, stitched overlays and classic TPU accents on the heel and eyestays.A variety of materials on the upper gives a modern look, while Max Air cushioning adds comfort to your journey.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "DB0625-200", "3" },
                    { 15, "Nike", "Pollen/Pink Blast/Black", "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.", "https://drive.google.com/uc?export=download&id=1tSgTxHUCeZU591E9hQI4Ax22NiD9wspM", "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh", "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf", "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya", "3", "3", "Nike SB Nyjah Free 2", 10000, 4, 500, "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.", "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48", "CU9224-700", "3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "24f7e4b7-7b4f-4349-ac7c-70a46867dfbf", "admin", "AppRole", "admin", null },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "9ca53e47-0f8d-4595-96c2-f95a44d3b552", "Staff", "AppRole", "staff", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "46136eeb-8970-4288-8a3b-2e06ee5c79ed", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEJMu4s+aoJ73BhZG69greVY/xeUlZKVsu9xgzr3pXRa8FIduXZTc08bHu5IdHl5o1w==", null, false, "9c7d5bed-64fb-406d-8f03-84f13724e94a", false, "Staff" },
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "0ed569ec-3f84-47f1-a884-e091455ee498", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEABpPksZdTIflcqNoVQZhGgNN180dRuuFAhH6G4sljjyf4i3YKTmXYG/kPM305gbnQ==", null, false, "4c802996-d7a1-4bc3-b7ac-1dbffa0ef012", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Paid", "bill_UserId" },
                values: new object[] { 1, 10000, "DE544998-A3CC-4E12-ABB4-0642E57BD222" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_Id", "cart_UserID" },
                values: new object[] { 1, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "review_id", "review_Comment", "review_UserId" },
                values: new object[] { 1, "Good", "DE544998-A3CC-4E12-ABB4-0642E57BD222" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "wl_Id", "wl_UserId" },
                values: new object[] { 1, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount" },
                values: new object[] { 1, 1, 10 });

            migrationBuilder.InsertData(
                table: "ProductInWishlist",
                columns: new[] { "piw_ProductId", "piw_WishlistId", "piw_amount" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInWishlist_piw_ProductId",
                table: "ProductInWishlist",
                column: "piw_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCategories_pic_CategoriesId",
                table: "ProductsInCategories",
                column: "pic_CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewInproduct_rip_ReviewId",
                table: "ReviewInproduct",
                column: "rip_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_review_UserId",
                table: "Reviews",
                column: "review_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_wl_UserId",
                table: "Wishlists",
                column: "wl_UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ContactSystems");

            migrationBuilder.DropTable(
                name: "ContactUsers");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "ProductInWishlist");

            migrationBuilder.DropTable(
                name: "ProductsInCategories");

            migrationBuilder.DropTable(
                name: "ReviewInproduct");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserInRoleModel");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
