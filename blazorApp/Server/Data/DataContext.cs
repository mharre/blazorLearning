﻿namespace blazorApp.Server.Data
{
    public class DataContext : DbContext
    {
        //dbcontext in simple terms allows us to query data from our db
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data for a specific entity
            modelBuilder.Entity<Product>().HasData(
	    	        new Product
	    	        {
	    	        	id = 1,
	    	        	title = "The Hitchhiker's Guide to the Galaxy",
	    	        	description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film. ",
	    	        	imageUrl ="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
	    	        	price = 9.99m
	    	        },
	    	        new Product
	    	        {
	    	        	id = 2,
	    	        	title = "Ready Player One",
	    	        	description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1]",
	    	        	imageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
	    	        	price = 7.99m
	    	        },
	    	        new Product
	    	        {
	    	        	id = 3,
	    	        	title = "Nineteen Eighty-Nine",
	    	        	description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated. ",
	    	        	imageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
	    	        	price = 10.99m
	    	        }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
