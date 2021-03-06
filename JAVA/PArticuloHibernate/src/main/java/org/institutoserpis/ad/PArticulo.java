package org.institutoserpis.ad;

import java.math.BigDecimal;
import java.util.*;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
public class PArticulo {

public static void main(String[] args) {
	// TODO Auto-generated method stub
	System.out.println("inicio");
	EntityManagerFactory entityManagerFactory = Persistence.createEntityManagerFactory("org.institutoserpis.ad");
	
	EntityManager entityManager = entityManagerFactory.createEntityManager();
	entityManager.getTransaction().begin();
	//LISTAR ARTICULOS
	List<Articulo> articulos = entityManager.createQuery("from Articulo",Articulo.class).getResultList();
	for(Articulo articulo : articulos)
		System.out.println(articulo.getNombre()+" "+articulo.getId());
	entityManager.getTransaction().commit();
	entityManager.close();
	entityManagerFactory.close();
	//BORRAR ARTICULO
	EntityManagerFactory entityManagerFactoryDelete = Persistence.createEntityManagerFactory("org.institutoserpis.ad");
	EntityManager entityManagerDelete = entityManagerFactoryDelete.createEntityManager();
	entityManagerDelete.getTransaction().begin();
	Articulo articulo=entityManagerDelete.find(Articulo.class, 1L);
	entityManagerDelete.remove(articulo);
	entityManagerDelete.getTransaction().commit();
	entityManagerDelete.close();
	entityManagerFactoryDelete.close();
	//INSERTAR ARTICULO
	EntityManagerFactory entityManagerFactoryInsert = Persistence.createEntityManagerFactory("org.institutoserpis.ad");
	EntityManager entityManagerInsert = entityManagerFactoryInsert.createEntityManager();
	entityManagerInsert.getTransaction().begin();
	Articulo articuloInsertar = new Articulo("Articulo200",2L,new BigDecimal(200));
	
}

}