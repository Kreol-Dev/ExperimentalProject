namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				} else { UnityEngine.Debug.Log("prop2 != null = false " +  IfStatement.AntiMergeValue++); }
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				} else { UnityEngine.Debug.Log("ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))) = false " +  IfStatement.AntiMergeValue++); }
			} else { UnityEngine.Debug.Log("StoredVariable0 != null = false " +  IfStatement.AntiMergeValue++); }
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = loc.AddComponent<Entity>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext9 != null)
								{
									GODelegate Lambda10 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													SpaceMarker subContext11 = (SpaceMarker)AddContext9.GetComponent(typeof(SpaceMarker)); //IsContext = True IsNew = False
													
													if(subContext11 != null)
													{
														
														{
															Space subContext12 = subContext11.CurrentSpace; //IsContext = True IsNew = False
															
															if(subContext12 != null)
															{
																Place OperandVar14 = default(Place); //IsContext = False IsNew = False
																Place StoredVariable13 = ((Place)subContext12.GetComponent(typeof(Place))); //IsContext = False IsNew = False
																if(StoredVariable13 != null)
																{
																	OperandVar14 = StoredVariable13;
																} else { UnityEngine.Debug.Log("StoredVariable13 != null = false " +  IfStatement.AntiMergeValue++); }
																subContext12.Detach( (OperandVar14));
															} else { UnityEngine.Debug.Log("subContext12 != null = false " +  IfStatement.AntiMergeValue++); }
														}
													} else { UnityEngine.Debug.Log("subContext11 != null = false " +  IfStatement.AntiMergeValue++); }
												}
											} else { UnityEngine.Debug.Log("entity != null = false " +  IfStatement.AntiMergeValue++); }
										}
									};
									AddContext9.OnDestruction(Lambda10);
								} else { UnityEngine.Debug.Log("AddContext9 != null = false " +  IfStatement.AntiMergeValue++); }
							}
							Place AddContext15 = loc.AddComponent<Place>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext15 != null)
								{
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop16 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									AddContext15.Size = (System.Int32)( (OperandVar17));
								} else { UnityEngine.Debug.Log("AddContext15 != null = false " +  IfStatement.AntiMergeValue++); }
							}
							Named AddContext18 = loc.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext18 != null)
								{
									
									
									
									
									
									System.String OperandVar20 = default(System.String); //IsContext = False IsNew = False
									System.String prop19 = External.RandomName(); //IsContext = False IsNew = False
									if(prop19 != null)
									{
										OperandVar20 = prop19;
									} else { UnityEngine.Debug.Log("prop19 != null = false " +  IfStatement.AntiMergeValue++); }
									AddContext18.Set( ("main_name"), ("_1"),( ( ("Location of "))) + ( ( (OperandVar20))));
								} else { UnityEngine.Debug.Log("AddContext18 != null = false " +  IfStatement.AntiMergeValue++); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar22 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable21 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable21 != null)
						{
							OperandVar22 = StoredVariable21;
						} else { UnityEngine.Debug.Log("StoredVariable21 != null = false " +  IfStatement.AntiMergeValue++); }
						subContext5.Attach( (OperandVar22));
					}
				} else { UnityEngine.Debug.Log("subContext5 != null = false " +  IfStatement.AntiMergeValue++); }
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar36 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable23 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable23 != null)
			{
				System.Boolean ifResult24; //IsContext = False IsNew = False
				
				System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop25 = StoredVariable23.ShowedObject; //IsContext = False IsNew = False
				if(prop25 != null)
				{
					System.Boolean ifResult26; //IsContext = False IsNew = False
					System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
					Named OperandVar28 = default(Named); //IsContext = False IsNew = False
					Named StoredVariable27 = ((Named)prop25.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable27 != null)
					{
						OperandVar28 = StoredVariable27;
					} else { UnityEngine.Debug.Log("StoredVariable27 != null = false " +  IfStatement.AntiMergeValue++); }
					System.Boolean prop29 = External.Has( (OperandVar28)); //IsContext = False IsNew = False
					OperandVar30 = prop29;
					if(ifResult26 =  (OperandVar30))
					{
						OperandVar31 = ifResult26;
					} else { UnityEngine.Debug.Log("ifResult26 =  (OperandVar30) = false " +  IfStatement.AntiMergeValue++); }
				} else { UnityEngine.Debug.Log("prop25 != null = false " +  IfStatement.AntiMergeValue++); }
				
				System.Boolean OperandVar35 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar33 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable32 = ((Blackboards.named_ui_marker)root.GetComponent(typeof(Blackboards.named_ui_marker))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					OperandVar33 = StoredVariable32;
				} else { UnityEngine.Debug.Log("StoredVariable32 != null = false " +  IfStatement.AntiMergeValue++); }
				System.Boolean prop34 = External.Has( (OperandVar33)); //IsContext = False IsNew = False
				OperandVar35 = prop34;
				if(ifResult24 = ( ( (OperandVar31))) && ( (!(OperandVar35))))
				{
					applicable = true;
					OperandVar36 = applicable;
				} else { UnityEngine.Debug.Log("ifResult24 = ( ( (OperandVar31))) && ( (!(OperandVar35))) = false " +  IfStatement.AntiMergeValue++); }
			} else { UnityEngine.Debug.Log("StoredVariable23 != null = false " +  IfStatement.AntiMergeValue++); }
			return (System.Boolean) (OperandVar36);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			
			root.AddComponent<Blackboards.named_ui_marker>();
			root.AddComponent<TextField>();
			
			{
				TextField subContext37 = (TextField)root.GetComponent(typeof(TextField)); //IsContext = True IsNew = False
				
				if(subContext37 != null)
				{
					System.String OperandVar42 = default(System.String); //IsContext = False IsNew = False
					UiObject StoredVariable38 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
					if(StoredVariable38 != null)
					{
						UnityEngine.GameObject prop39 = StoredVariable38.ShowedObject; //IsContext = False IsNew = False
						if(prop39 != null)
						{
							Named StoredVariable40 = ((Named)prop39.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable40 != null)
							{
								
								System.String prop41 = StoredVariable40.Get( ("main_name")); //IsContext = False IsNew = False
								if(prop41 != null)
								{
									OperandVar42 = prop41;
								} else { UnityEngine.Debug.Log("prop41 != null = false " +  IfStatement.AntiMergeValue++); }
							} else { UnityEngine.Debug.Log("StoredVariable40 != null = false " +  IfStatement.AntiMergeValue++); }
						} else { UnityEngine.Debug.Log("prop39 != null = false " +  IfStatement.AntiMergeValue++); }
					} else { UnityEngine.Debug.Log("StoredVariable38 != null = false " +  IfStatement.AntiMergeValue++); }
					subContext37.Set( (OperandVar42));
				} else { UnityEngine.Debug.Log("subContext37 != null = false " +  IfStatement.AntiMergeValue++); }
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar48 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable43 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable43 != null)
			{
				GenerateMarker StoredVariable44 = ((GenerateMarker)StoredVariable43.GetComponent(typeof(GenerateMarker))); //IsContext = False IsNew = False
				if(StoredVariable44 != null)
				{
					System.Boolean ifResult45; //IsContext = False IsNew = False
					
					System.Collections.Generic.List<Agent> OperandVar47 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					if(StoredVariable43 != null)
					{
						System.Collections.Generic.List<Agent> prop46 = StoredVariable43.Agents; //IsContext = False IsNew = False
						if(prop46 != null)
						{
							OperandVar47 = prop46;
						} else { UnityEngine.Debug.Log("prop46 != null = false " +  IfStatement.AntiMergeValue++); }
					} else { UnityEngine.Debug.Log("StoredVariable43 != null = false " +  IfStatement.AntiMergeValue++); }
					
					
					if(ifResult45 = ( ( (OperandVar47 != null ? OperandVar47.Count : 0))) == ( ( (0f))))
					{
						applicable = true;
						OperandVar48 = applicable;
					} else { UnityEngine.Debug.Log("ifResult45 = ( ( (OperandVar47 != null ? OperandVar47.Count : 0))) == ( ( (0f))) = false " +  IfStatement.AntiMergeValue++); }
				} else { UnityEngine.Debug.Log("StoredVariable44 != null = false " +  IfStatement.AntiMergeValue++); }
			} else { UnityEngine.Debug.Log("StoredVariable43 != null = false " +  IfStatement.AntiMergeValue++); }
			return (System.Boolean) (OperandVar48);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			
			
			{
				Place subContext49 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				
				if(subContext49 != null)
				{
					
					subContext49.Size = (System.Int32)( (5f));
					System.Single OperandVar51 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop50 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar51 = prop50;
					for (int i = 0; i <  (OperandVar51); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag52 = ag; //IsContext = True IsNew = False
							Entity AddContext53 = ag.AddComponent<Entity>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext53 != null)
								{
									GODelegate Lambda54 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													PlaceMarker subContext55 = (PlaceMarker)AddContext53.GetComponent(typeof(PlaceMarker)); //IsContext = True IsNew = False
													
													if(subContext55 != null)
													{
														
														{
															Place subContext56 = subContext55.CurrentPlace; //IsContext = True IsNew = False
															
															if(subContext56 != null)
															{
																Agent OperandVar58 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable57 = ((Agent)subContext56.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
																if(StoredVariable57 != null)
																{
																	OperandVar58 = StoredVariable57;
																} else { UnityEngine.Debug.Log("StoredVariable57 != null = false " +  IfStatement.AntiMergeValue++); }
																subContext56.Detach( (OperandVar58));
															} else { UnityEngine.Debug.Log("subContext56 != null = false " +  IfStatement.AntiMergeValue++); }
														}
													} else { UnityEngine.Debug.Log("subContext55 != null = false " +  IfStatement.AntiMergeValue++); }
												}
											} else { UnityEngine.Debug.Log("entity != null = false " +  IfStatement.AntiMergeValue++); }
										}
									};
									AddContext53.OnDestruction(Lambda54);
								} else { UnityEngine.Debug.Log("AddContext53 != null = false " +  IfStatement.AntiMergeValue++); }
							}
							Agent AddContext59 = ag.AddComponent<Agent>(); //IsContext = True IsNew = True
							Blackboards.human AddContext60 = ag.AddComponent<Blackboards.human>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext60 != null)
								{
									System.Single OperandVar62 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop61 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar62 = prop61;
									AddContext60.Age = (System.Int32)( (OperandVar62));
								} else { UnityEngine.Debug.Log("AddContext60 != null = false " +  IfStatement.AntiMergeValue++); }
							}
							Named AddContext63 = ag.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext63 != null)
								{
									
									
									System.String OperandVar65 = default(System.String); //IsContext = False IsNew = False
									System.String prop64 = External.RandomName(); //IsContext = False IsNew = False
									if(prop64 != null)
									{
										OperandVar65 = prop64;
									} else { UnityEngine.Debug.Log("prop64 != null = false " +  IfStatement.AntiMergeValue++); }
									AddContext63.Set( ("main_name"), ("_1"), (OperandVar65));
								} else { UnityEngine.Debug.Log("AddContext63 != null = false " +  IfStatement.AntiMergeValue++); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar67 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable66 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable66 != null)
						{
							OperandVar67 = StoredVariable66;
						} else { UnityEngine.Debug.Log("StoredVariable66 != null = false " +  IfStatement.AntiMergeValue++); }
						subContext49.Attach( (OperandVar67));
					}
				} else { UnityEngine.Debug.Log("subContext49 != null = false " +  IfStatement.AntiMergeValue++); }
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar74 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable68 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable68 != null)
			{
				System.Boolean ifResult69; //IsContext = False IsNew = False
				System.Boolean OperandVar73 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar71 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable70 = ((Blackboards.event_marker)StoredVariable68.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable70 != null)
				{
					OperandVar71 = StoredVariable70;
				} else { UnityEngine.Debug.Log("StoredVariable70 != null = false " +  IfStatement.AntiMergeValue++); }
				System.Boolean prop72 = External.Has( (OperandVar71)); //IsContext = False IsNew = False
				OperandVar73 = prop72;
				if(ifResult69 = !(OperandVar73))
				{
					applicable = true;
					OperandVar74 = applicable;
				} else { UnityEngine.Debug.Log("ifResult69 = !(OperandVar73) = false " +  IfStatement.AntiMergeValue++); }
			} else { UnityEngine.Debug.Log("StoredVariable68 != null = false " +  IfStatement.AntiMergeValue++); }
			return (System.Boolean) (OperandVar74);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			
			root.AddComponent<Blackboards.event_marker>();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar81 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable75 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable75 != null)
			{
				System.Boolean ifResult76; //IsContext = False IsNew = False
				System.Boolean OperandVar80 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar78 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable77 = ((Blackboards.personality)StoredVariable75.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable77 != null)
				{
					OperandVar78 = StoredVariable77;
				} else { UnityEngine.Debug.Log("StoredVariable77 != null = false " +  IfStatement.AntiMergeValue++); }
				System.Boolean prop79 = External.Has( (OperandVar78)); //IsContext = False IsNew = False
				OperandVar80 = prop79;
				if(ifResult76 = !(OperandVar80))
				{
					applicable = true;
					OperandVar81 = applicable;
				} else { UnityEngine.Debug.Log("ifResult76 = !(OperandVar80) = false " +  IfStatement.AntiMergeValue++); }
			} else { UnityEngine.Debug.Log("StoredVariable75 != null = false " +  IfStatement.AntiMergeValue++); }
			return (System.Boolean) (OperandVar81);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root.ToString() + IfStatement.AntiMergeValue++);
			
			
			
			root.AddComponent<Blackboards.personality>();
		}
        }
    }
}
