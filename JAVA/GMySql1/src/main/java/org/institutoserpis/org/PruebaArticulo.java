package org.institutoserpis.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.sql.SQLException;
import java.sql.ResultSet;
import java.util.Scanner;

public class PruebaArticulo {
             public static void main(String[] args) throws SQLException {
            	    Connection connection = DriverManager.getConnection(
            	    		"jdbc:mysql://localhost/dbprueba", "root", "sistemas");
            	    //connection.close();
            	    //System.out.println("fin");
            	    int opcionMenu=0;
            	    Scanner tec = new Scanner (System.in);
            	    do {
            	        System.out.println("1.- Leer");
            	        System.out.println("2.- Nuevo");
            	        System.out.println("3.- Editar");
            	        System.out.println("4.- Eliminar");
            	        System.out.println("5.- Listar todos");
            	        System.out.println("0.- Salir");
            	        System.out.println("Introduce una opcion:");
            	        opcionMenu = tec.nextInt();
            	        switch(opcionMenu){
            	        case 1:
            	        	 System.out.println("----MOSTRAR DATOS----");
            	        	 Statement stmt = (Statement) connection.createStatement();
            	        	 ResultSet rs = stmt.executeQuery("Select * From articulo");
            	        	 while(rs.next()) {
            	        		  System.out.print(rs.getString("id")+". ");
            	        		  System.out.println(rs.getString("nombre"));
            	        	 }
            	        	 break;
            	        case 2: 
            	        	 //System.out.println("2");
            	        	 break;
            	        case 3:
            	        	 //System.out.println("3");
            	        	 break;
            	        case 4:
            	        	 //System.out.println("4");
            	        	 break;
            	        case 5:
            	        	 //System.out.println("5");
            	        	 break;
            	        }
            	        
            	    }while(opcionMenu!=0);    
             }
             
}
