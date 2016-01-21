package org.institutoserpis.ad;

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
	List<Articulo> articulos = entityManager.createQuery("from Articulo",Articulo.class).getResultList();
	for(Articulo articulo : articulos)
		System.out.println(articulo.getNombre());
	entityManager.getTransaction().commit();
	entityManager.close();
	entityManagerFactory.close();
	}

}