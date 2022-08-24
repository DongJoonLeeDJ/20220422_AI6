package random;

public class MyTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Student.year = 10;
		Student.printYear();
		
		Student s = new Student();
		s.year = 500; //인스턴스로도 static 붙은 변수나
		s.printYear(); //메소드에 접근하는 건 java만 가능(대신 경고는 뜬다)
		Student.printYear();
	}

}
