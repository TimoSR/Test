using ConsoleApp1.Fundamentals;

namespace TestProject1; 

[TestFixture]
public class ReservationTests
{

    /*
     * CanBeCancelledBy_Scenario_ExpectedResult
     */
    
    [Test]
    public void CanBeCancelledBy_AdminCancelling_Returns_True()
    {
        // Arrange
        var reservation = new Reservation();
        
        // Act
        var result = reservation.CanBeCancelledBy(new User{IsAdmin = true});
        
        //Assert
        Assert.That(result, Is.True);
        
    }

}