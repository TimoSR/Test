using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestProject1;

[TestFixture]
public class ReservationTests
{
    
    /*
     *
     * CanBeCancelledBy_Scenario_ExpectedBehavior
     *
     * Arrange
     *
     * Act
     *
     * Assert
     * 
     */

    [Test]
    public void CanBeCancelledBy_AdminCalling_ReturnsTrue()
    {
        
        // Arrange

        var reservation = new Reservation();

        // Act
        
        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

        // Assert
        
        Assert.That(result, Is.True);

    }


}