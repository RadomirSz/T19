import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        Szedulec sz = new Szedulec(5);
        Sorter s = new Sorter();

        List<Task> Tasks = sz.getTasks();
        // sortuj
        Tasks = s.sortuj(Tasks);
        for(Task task : Tasks){
            Thread thread = new Thread(()->{
                System.out.println(Thread.currentThread().getName() + " " + task.getDescription() + " " + Thread.currentThread().getPriority());
            });
            thread.setPriority(task.getPriority());
            thread.start();
        }
    }
}

class Task
{
    public String getDescription() {
        return description;
    }

    private String description;

    public int getPriority() {
        return priority;
    }

    private final int priority;

    public Task(int priority) {
        this.priority = priority;
        description = "priorytet: " + priority;
    }

}

class Szedulec
{
    private List<Task> Tasks;

    public Szedulec(int n) {
        Tasks = new ArrayList<Task>();
        Random r = new Random();
        for (int i = 0; i < n; i++) {
            Tasks.add(new Task(r.nextInt(1,10)));
        }
    }

    public List<Task> getTasks() {
        return Tasks;
    }
}

class Sorter
{
    public List<Task> sortuj(List<Task> lista){

        return lista;
    }
}