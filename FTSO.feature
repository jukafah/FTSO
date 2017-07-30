Feature: Candidate Feedback

Scenario: Generate Candidate template
    Given candidate "Amber Joy"
    And with general screen notes
        """
        Amber displayed confidence and an impressive capability of thinking outside the box. 
        Our discussion was quite interesting because she naturally started gravitating towards good engineering practices without knowing the actual practice itself. 
        I gave them names and she wrote them down and was generally interested in what they were. 
        This demonstrates a determination to learn and also an understanding that engineering is largely about patterns and how you work with them. 
        Her coming to the solutions herself is impressive. She explained test case construction adequately as well as how you would validate a software requirement through assertions. 
        Her development skills are there, but her testing specific practices are not as there. 
        She related learning different programming languages to that of different spoken languages, further reinforcing her engineering practices on structure being important as well as patterns. 
        She understood the difference between weakly and strongly typed languages, but she did not know to refer to them in that manner.

        I consider Amber a mid level candidate (Automation Engineer II) and would also recommend her for review in a timeframe of 6 months - 1 year for a Sr. Automation Engineer position. 
        She will do best on a project with C#, Java (she would have ramp up time on Java, but it translates from C# well), JavaScript or TypeScript. 
        We would benefit even more on having a good lead or mentor fill out her engineering and testing practices. 
        She also has a more accelerated learning rate than I have probably ever interviewed, and she is going to be thirsty for improving herself and advancing her career. 
        She spoke very well, was honest when she didn’t know answers, and she was genuinely interested in our discussion.
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
    And general notes
        """
        - Participated in code reviews and thinks of them as an opportunity for growth
        - Described how to construct tests and validate said tests with asserts very well and at different levels in a test suite
        - Has a large portfolio of work which shows she’s active in this industry and enjoys it
        - Did not know the difference between abstract and non abstract classes
            That’s okay, she `knew` about them, but I wouldn’t have any worry introducing her to new concepts
        - Gave a good example of why you may use default vs custom error messaging
        - She talked quite a lot on how she prefers Fluent Asserts, which is great.
        - Described how default asserts are the way to go when comparing things like primitives directly, but custom error messaging for asserts objects and needing specific details from an object with possibly many properties
        - Knew what strong typing and weak typing was even though she didn’t know it by the name
        - Knew of, but did not know how to apply TDD / BDD
        - Described how to implement reusable components in a test framework
        - Described DRY, but did not know DAMP
        - She understood the description of it and that they balance each other out
        - Described what her thoughts on `acceptable unit test coverage` was
        - Wasn’t super familiar with test frameworks
        - Has the most experience extending / contributing to already existing test frameworks
            It wouldn’t take her long to do it herself
        """
    When I generate candidate template
    Then candidate profile is complete