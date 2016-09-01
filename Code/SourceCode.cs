namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = root.GetComponent<Space>(); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				} else { UnityEngine.Debug.Log("prop2 != null = false " ); }
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				} else { UnityEngine.Debug.Log("ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable0 != null = false " ); }
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Space subContext5 = root.GetComponent<Space>(); //IsContext = True IsNew = False
				
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
													SpaceMarker subContext11 = AddContext9.GetComponent<SpaceMarker>(); //IsContext = True IsNew = False
													
													if(subContext11 != null)
													{
														
														{
															Space subContext12 = subContext11.CurrentSpace; //IsContext = True IsNew = False
															
															if(subContext12 != null)
															{
																Place OperandVar14 = default(Place); //IsContext = False IsNew = False
																Place StoredVariable13 = subContext12.GetComponent<Place>(); //IsContext = False IsNew = False
																if(StoredVariable13 != null)
																{
																	OperandVar14 = StoredVariable13;
																} else { UnityEngine.Debug.Log("StoredVariable13 != null = false " ); }
																subContext12.Detach( (OperandVar14));
															} else { UnityEngine.Debug.Log("subContext12 != null = false " ); }
														}
													} else { UnityEngine.Debug.Log("subContext11 != null = false " ); }
												}
											} else { UnityEngine.Debug.Log("entity != null = false " ); }
										}
									};
									AddContext9.OnDestruction(Lambda10);
								} else { UnityEngine.Debug.Log("AddContext9 != null = false " ); }
							}
							Place AddContext15 = loc.AddComponent<Place>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext15 != null)
								{
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop16 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									AddContext15.Size = (System.Int32)( (OperandVar17));
								} else { UnityEngine.Debug.Log("AddContext15 != null = false " ); }
							}
							Named AddContext18 = loc.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext18 != null)
								{
									
									
									
									AddContext18.Set( ("main_name"), ("_1"), ("Some location"));
								} else { UnityEngine.Debug.Log("AddContext18 != null = false " ); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar20 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable19 = loc.GetComponent<Place>(); //IsContext = False IsNew = False
						if(StoredVariable19 != null)
						{
							OperandVar20 = StoredVariable19;
						} else { UnityEngine.Debug.Log("StoredVariable19 != null = false " ); }
						subContext5.Attach( (OperandVar20));
					}
				} else { UnityEngine.Debug.Log("subContext5 != null = false " ); }
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar35 = default(System.Boolean); //IsContext = False IsNew = False
			Card StoredVariable21 = root.GetComponent<Card>(); //IsContext = False IsNew = False
			if(StoredVariable21 != null)
			{
				UiObject StoredVariable22 = StoredVariable21.GetComponent<UiObject>(); //IsContext = False IsNew = False
				if(StoredVariable22 != null)
				{
					System.Boolean ifResult23; //IsContext = False IsNew = False
					
					System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop24 = StoredVariable22.ShowedObject; //IsContext = False IsNew = False
					if(prop24 != null)
					{
						System.Boolean ifResult25; //IsContext = False IsNew = False
						System.Boolean OperandVar29 = default(System.Boolean); //IsContext = False IsNew = False
						Named OperandVar27 = default(Named); //IsContext = False IsNew = False
						Named StoredVariable26 = prop24.GetComponent<Named>(); //IsContext = False IsNew = False
						if(StoredVariable26 != null)
						{
							OperandVar27 = StoredVariable26;
						} else { UnityEngine.Debug.Log("StoredVariable26 != null = false " ); }
						System.Boolean prop28 = External.Has( (OperandVar27)); //IsContext = False IsNew = False
						OperandVar29 = prop28;
						if(ifResult25 =  (OperandVar29))
						{
							OperandVar30 = ifResult25;
						} else { UnityEngine.Debug.Log("ifResult25 =  (OperandVar29) = false " ); }
					} else { UnityEngine.Debug.Log("prop24 != null = false " ); }
					
					System.Boolean OperandVar34 = default(System.Boolean); //IsContext = False IsNew = False
					Blackboards.named_ui_marker OperandVar32 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
					Blackboards.named_ui_marker StoredVariable31 = root.GetComponent<Blackboards.named_ui_marker>(); //IsContext = False IsNew = False
					if(StoredVariable31 != null)
					{
						OperandVar32 = StoredVariable31;
					} else { UnityEngine.Debug.Log("StoredVariable31 != null = false " ); }
					System.Boolean prop33 = External.Has( (OperandVar32)); //IsContext = False IsNew = False
					OperandVar34 = prop33;
					if(ifResult23 = ( ( (OperandVar30))) && ( (!(OperandVar34))))
					{
						applicable = true;
						OperandVar35 = applicable;
					} else { UnityEngine.Debug.Log("ifResult23 = ( ( (OperandVar30))) && ( (!(OperandVar34))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable22 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable21 != null = false " ); }
			return (System.Boolean) (OperandVar35);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.named_ui_marker>();
			root.AddComponent<TextField>();
			
			{
				TextField subContext36 = root.GetComponent<TextField>(); //IsContext = True IsNew = False
				
				if(subContext36 != null)
				{
					System.String OperandVar41 = default(System.String); //IsContext = False IsNew = False
					Card StoredVariable37 = root.GetComponent<Card>(); //IsContext = False IsNew = False
					if(StoredVariable37 != null)
					{
						UnityEngine.GameObject prop38 = StoredVariable37.ShowedObject; //IsContext = False IsNew = False
						if(prop38 != null)
						{
							Named StoredVariable39 = prop38.GetComponent<Named>(); //IsContext = False IsNew = False
							if(StoredVariable39 != null)
							{
								
								System.String prop40 = StoredVariable39.Get( ("main_name")); //IsContext = False IsNew = False
								if(prop40 != null)
								{
									OperandVar41 = prop40;
								} else { UnityEngine.Debug.Log("prop40 != null = false " ); }
							} else { UnityEngine.Debug.Log("StoredVariable39 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop38 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable37 != null = false " ); }
					subContext36.Set( (OperandVar41));
				} else { UnityEngine.Debug.Log("subContext36 != null = false " ); }
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar47 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable42 = root.GetComponent<Place>(); //IsContext = False IsNew = False
			if(StoredVariable42 != null)
			{
				GenerateMarker StoredVariable43 = StoredVariable42.GetComponent<GenerateMarker>(); //IsContext = False IsNew = False
				if(StoredVariable43 != null)
				{
					System.Boolean ifResult44; //IsContext = False IsNew = False
					
					System.Collections.Generic.List<Agent> OperandVar46 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					if(StoredVariable42 != null)
					{
						System.Collections.Generic.List<Agent> prop45 = StoredVariable42.Agents; //IsContext = False IsNew = False
						if(prop45 != null)
						{
							OperandVar46 = prop45;
						} else { UnityEngine.Debug.Log("prop45 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable42 != null = false " ); }
					
					
					if(ifResult44 = ( ( (OperandVar46 != null ? OperandVar46.Count : 0))) == ( ( (0f))))
					{
						applicable = true;
						OperandVar47 = applicable;
					} else { UnityEngine.Debug.Log("ifResult44 = ( ( (OperandVar46 != null ? OperandVar46.Count : 0))) == ( ( (0f))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable43 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable42 != null = false " ); }
			return (System.Boolean) (OperandVar47);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Place subContext48 = root.GetComponent<Place>(); //IsContext = True IsNew = False
				
				if(subContext48 != null)
				{
					
					subContext48.Size = (System.Int32)( (5f));
					System.Single OperandVar50 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop49 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar50 = prop49;
					for (int i = 0; i <  (OperandVar50); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag51 = ag; //IsContext = True IsNew = False
							Entity AddContext52 = ag.AddComponent<Entity>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext52 != null)
								{
									GODelegate Lambda53 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											
											if(entity != null)
											{
												
												{
													PlaceMarker subContext54 = AddContext52.GetComponent<PlaceMarker>(); //IsContext = True IsNew = False
													
													if(subContext54 != null)
													{
														
														{
															Place subContext55 = subContext54.CurrentPlace; //IsContext = True IsNew = False
															
															if(subContext55 != null)
															{
																Agent OperandVar57 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable56 = subContext55.GetComponent<Agent>(); //IsContext = False IsNew = False
																if(StoredVariable56 != null)
																{
																	OperandVar57 = StoredVariable56;
																} else { UnityEngine.Debug.Log("StoredVariable56 != null = false " ); }
																subContext55.Detach( (OperandVar57));
															} else { UnityEngine.Debug.Log("subContext55 != null = false " ); }
														}
													} else { UnityEngine.Debug.Log("subContext54 != null = false " ); }
												}
											} else { UnityEngine.Debug.Log("entity != null = false " ); }
										}
									};
									AddContext52.OnDestruction(Lambda53);
								} else { UnityEngine.Debug.Log("AddContext52 != null = false " ); }
							}
							Agent AddContext58 = ag.AddComponent<Agent>(); //IsContext = True IsNew = True
							Blackboards.human AddContext59 = ag.AddComponent<Blackboards.human>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext59 != null)
								{
									System.Single OperandVar61 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop60 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar61 = prop60;
									AddContext59.Age = (System.Int32)( (OperandVar61));
								} else { UnityEngine.Debug.Log("AddContext59 != null = false " ); }
							}
							Named AddContext62 = ag.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext62 != null)
								{
									
									
									
									
									
									System.Single OperandVar64 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop63 = External.Random( (0f), (1000f)); //IsContext = False IsNew = False
									OperandVar64 = prop63;
									AddContext62.Set( ("main_name"), ("_1"),( ( ("Some agent"))) + ( ( (OperandVar64))));
								} else { UnityEngine.Debug.Log("AddContext62 != null = false " ); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar66 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable65 = ag.GetComponent<Agent>(); //IsContext = False IsNew = False
						if(StoredVariable65 != null)
						{
							OperandVar66 = StoredVariable65;
						} else { UnityEngine.Debug.Log("StoredVariable65 != null = false " ); }
						subContext48.Attach( (OperandVar66));
					}
				} else { UnityEngine.Debug.Log("subContext48 != null = false " ); }
			}
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar73 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable67 = root.GetComponent<Agent>(); //IsContext = False IsNew = False
			if(StoredVariable67 != null)
			{
				System.Boolean ifResult68; //IsContext = False IsNew = False
				System.Boolean OperandVar72 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar70 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable69 = StoredVariable67.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable69 != null)
				{
					OperandVar70 = StoredVariable69;
				} else { UnityEngine.Debug.Log("StoredVariable69 != null = false " ); }
				System.Boolean prop71 = External.Has( (OperandVar70)); //IsContext = False IsNew = False
				OperandVar72 = prop71;
				if(ifResult68 = !(OperandVar72))
				{
					applicable = true;
					OperandVar73 = applicable;
				} else { UnityEngine.Debug.Log("ifResult68 = !(OperandVar72) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable67 != null = false " ); }
			return (System.Boolean) (OperandVar73);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.personality>();
		}
        }
    }
    
    public class event_scientist_rescue : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar75 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable74 = root.GetComponent<Place>(); //IsContext = False IsNew = False
			if(StoredVariable74 != null)
			{
				applicable = true;
				OperandVar75 = applicable;
			} else { UnityEngine.Debug.Log("StoredVariable74 != null = false " ); }
			return (System.Boolean) (OperandVar75);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			System.Single OperandVar77 = default(System.Single); //IsContext = False IsNew = False
			
			
			System.Single prop76 = External.Random( (0f), (100f)); //IsContext = False IsNew = False
			OperandVar77 = prop76;
			
			
			if(( ( (OperandVar77))) > ( ( (90f))))
			{
				
				ut =  (1f);
			} else { UnityEngine.Debug.Log("( ( (OperandVar77))) > ( ( (90f))) = false " ); }
			
			ut =  (0f);
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			UnityEngine.GameObject ev = new UnityEngine.GameObject("ev"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ev78 = ev; //IsContext = True IsNew = False
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ev);
		}
        }
    }
}
