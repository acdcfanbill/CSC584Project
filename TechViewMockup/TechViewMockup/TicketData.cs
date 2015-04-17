using System;

public class TicketData
{
    private int ticketId;
    private String description;
    private int priority;
    private int status;

    public TicketData()
    {
    }

    public String getTicketId() {
        return this.ticketId.ToString();
    }

    public String getDescription()
    {
        return this.description;
    }

    public String getPriority()
    {
        return null;
    }

    public String getStatus() {
        return null;
    }

}