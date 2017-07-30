Feature: Candidate Feedback

Scenario: Generate Candidate template
    Given candidate "John Steinmann"
    And with general screen notes
        """
     
        """
    When I evalute skill placements
        | Skill                     | Level |
        | Test Tools                |   2   |
        | Test Frameworks           |   1   |
        | Test Engineering          |   3   |
        | Test Practices            |   3   |
        | Test Infrastructure       |   3   |
        | Test Delivery             |   2   |
        | Programming               |   3   |
        | Object Oriented Design    |   3   |
        | Development Tools         |   3   |
        | SDLC                      |   3   |
        | General Knowledge         |   3   |
    And detailed notes
        """
        
        """
    When I generate candidate template
    Then candidate profile is complete