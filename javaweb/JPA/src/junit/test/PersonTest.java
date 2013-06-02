package junit.test;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import org.junit.BeforeClass;
import org.junit.Test;

import com.dawndiy.bean.Person;

public class PersonTest {

	@BeforeClass
	public static void setUpBeforeClass() throws Exception {
	}

	@Test
	public void save() {
		EntityManagerFactory factory = Persistence.createEntityManagerFactory("com.dawndiy.jpa");
//		EntityManager em = factory.createEntityManager();
//		em.getTransaction().begin();	// 开启事务
//		Person p = new Person();
//		p.setName("DawnDIY");
//		em.persist(p);
//		em.getTransaction().commit();
//		em.close();
		factory.close();
	}

}
