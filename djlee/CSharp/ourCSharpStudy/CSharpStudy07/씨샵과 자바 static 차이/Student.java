package random;

public class Student {

	private int age;
	public static int year;
	public static void printYear()
	{
		//static  붙은 메소드 안에선
		//static 붙은 속성만 쓸 수 있다.
		//이건 C#에도 있는 특징
		//System.out.println(age);
		System.out.println(year);
	}
	
	public int getAge() {
		return age;
	}
	//단, static 없는 메소드 안에서는
	//static 붙은 변수를 쓸 수 있다.
	//이건 C#에도 있는 특징
	public void setAge(int age) {
		this.age = age;
		year = age;
	}
	
}














